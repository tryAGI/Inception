using System.Net;
using System.Text;
using System.Text.Json;
using Inception;
using Meai = Microsoft.Extensions.AI;

using var native = new InceptionClient("test-key", httpClient: new HttpClient(new FixtureHandler()),
    baseUri: new Uri("https://example.test"));
var decisions = await native.Decisions.CreateDecisionAsync(new DecisionRequest
{
    Model = "mercury-decide", State = "Refund the duplicate charge",
    Questions = new()
    {
        ["billing"] = new NoulQuestion { Instructions = "Is this billing?" },
        ["team"] = new ChoiceQuestion { Criteria = Parse("""{"billing":"Refunds"}""") },
        ["priority"] = new ScoreQuestion { Criteria = ["low", "high"] },
    },
});
if (!decisions.Answers["billing"].IsNoul || !decisions.Answers["team"].IsChoice || !decisions.Answers["priority"].IsScore)
    throw new InvalidOperationException("Decision union round-trip failed.");

Meai.IChatClient client = native;
var messages = new Meai.ChatMessage[]
{
    new(Meai.ChatRole.Assistant, [new Meai.FunctionCallContent("call-1", "weather", new Dictionary<string, object?> { ["city"] = "Dubai" })]),
    new(Meai.ChatRole.Tool, [new Meai.FunctionResultContent("call-1", new Dictionary<string, object?> { ["temperature"] = 30, ["conditions"] = new object[] { "sunny", true } })]),
};
var options = new Meai.ChatOptions
{
    Tools = [Meai.AIFunctionFactory.CreateDeclaration("weather", "Get weather", Parse("""{"type":"object","properties":{"city":{"type":"string"}},"required":["city"]}"""))],
    ToolMode = Meai.ChatToolMode.RequireSpecific("weather"),
    AdditionalProperties = new() { ["reasoning_effort"] = "instant", ["realtime"] = true },
};
var response = await client.GetResponseAsync(messages, options);
if (response.Text != "Hello Dubai" || response.Usage?.TotalTokenCount != 6)
    throw new InvalidOperationException("MEAI response/usage round-trip failed.");
var streamed = new StringBuilder();
await foreach (var update in client.GetStreamingResponseAsync(messages, options)) streamed.Append(update.Text);
if (streamed.ToString() != "Hello Dubai") throw new InvalidOperationException("MEAI streaming failed.");
Console.WriteLine("NativeAOT: decision unions, dynamic tool arguments/results, MEAI chat, usage, and SSE passed.");

static JsonElement Parse(string json)
{
    using var document = JsonDocument.Parse(json);
    return document.RootElement.Clone();
}

internal sealed class FixtureHandler : HttpMessageHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        using var body = JsonDocument.Parse(await request.Content!.ReadAsStringAsync(cancellationToken));
        if (request.RequestUri!.AbsolutePath == "/v1/decisions")
        {
            if (body.RootElement.GetProperty("questions").GetProperty("team").GetProperty("type").GetString() != "choice")
                throw new InvalidOperationException("Decision serialization failed.");
            return Json("""{"model":"mercury-decide","answers":{"billing":{"type":"noul","noul":0.9},"team":{"type":"choice","choice":"billing","probabilities":{"billing":1},"confidence":1},"priority":{"type":"score","score":1,"legend":{"0":"low","1":"high"},"probabilities":{"0":0,"1":1},"confidence":1}},"usage":{"input_tokens":20,"output_tokens":3}}""");
        }
        if (body.RootElement.GetProperty("messages")[1].GetProperty("tool_call_id").GetString() != "call-1")
            throw new InvalidOperationException("MEAI tool history serialization failed.");
        var usage = """{"prompt_tokens":4,"completion_tokens":2,"total_tokens":6,"prompt_tokens_details":{"cached_tokens":1},"completion_tokens_details":{"reasoning_tokens":1}}""";
        if (body.RootElement.GetProperty("stream").GetBoolean())
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("data: {\"id\":\"chat-test\",\"object\":\"chat.completion.chunk\",\"created\":1,\"model\":\"mercury-3\",\"choices\":[{\"index\":0,\"delta\":{\"content\":\"Hello Dubai\"},\"finish_reason\":\"stop\"}]}\n\ndata: {\"id\":\"chat-test\",\"object\":\"chat.completion.chunk\",\"created\":1,\"model\":\"mercury-3\",\"choices\":[],\"usage\":" + usage + "}\n\ndata: [DONE]\n\n", Encoding.UTF8, "text/event-stream"),
            };
        return Json("""{"id":"chat-test","object":"chat.completion","created":1,"model":"mercury-3","choices":[{"index":0,"message":{"role":"assistant","content":"Hello Dubai"},"finish_reason":"stop"}],"usage":USAGE}""".Replace("USAGE", usage, StringComparison.Ordinal));
    }

    private static HttpResponseMessage Json(string content) => new(HttpStatusCode.OK)
    {
        Content = new StringContent(content, Encoding.UTF8, "application/json"),
    };
}
