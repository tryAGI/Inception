using System.Net;
using System.Text;
using System.Text.Json;
using Meai = Microsoft.Extensions.AI;

namespace Inception.IntegrationTests;

public partial class Tests
{
    private const string UsageJson = """{"prompt_tokens":4,"completion_tokens":2,"total_tokens":6,"prompt_tokens_details":{"cached_tokens":1},"completion_tokens_details":{"reasoning_tokens":1}}""";
    private const string ChatJson = """{"id":"chat-test","object":"chat.completion","created":1,"model":"mercury-3","choices":[{"index":0,"message":{"role":"assistant","content":"Hello Dubai"},"finish_reason":"stop"}],"usage":USAGE}""";

    [TestMethod]
    [DataRow("all", "/v1/models")]
    [DataRow("chat", "/v1/chat/completions/models")]
    [DataRow("fim", "/v1/fim/completions/models")]
    [DataRow("edit", "/v1/edit/completions/models")]
    public async Task Catalogs_UseCorrectRouteAndBearerAuth(string catalog, string path)
    {
        var handler = new Handler("""{"data":[]}""");
        using var client = FakeClient(handler);
        var response = catalog switch
        {
            "chat" => await client.Models.ListChatModelsAsync(),
            "fim" => await client.Models.ListFIMModelsAsync(),
            "edit" => await client.Models.ListEditModelsAsync(),
            _ => await client.Models.ListModelsAsync(),
        };
        response.Data.Should().BeEmpty();
        handler.Path.Should().Be(path);
        handler.Authorization.Should().Be("Bearer test-key");
    }

    [TestMethod]
    public async Task Chat_PreservesNativeLatencyAndSchemaControls()
    {
        var handler = new Handler(ChatJson.Replace("USAGE", UsageJson, StringComparison.Ordinal));
        using var client = FakeClient(handler);
        var request = ChatRequest();
        request.ReasoningSummary = true;
        request.ResponseFormat = new ResponseFormatJSONObject();
        var response = await client.Chat.CreateChatCompletionAsync(request);
        response.Choices[0].Message.Content?.Value1.Should().Be("Hello Dubai");
        handler.Path.Should().Be("/v1/chat/completions");
        using var body = JsonDocument.Parse(handler.Body!);
        body.RootElement.GetProperty("reasoning_effort").GetString().Should().Be("instant");
        body.RootElement.GetProperty("realtime").GetBoolean().Should().BeTrue();
        body.RootElement.GetProperty("reasoning_summary").GetBoolean().Should().BeTrue();
        body.RootElement.GetProperty("response_format").GetProperty("type").GetString().Should().Be("json_object");
    }

    [TestMethod]
    public async Task Decisions_RoundTripAllThreeNamedUnionTypes()
    {
        var handler = new Handler("""{"model":"mercury-decide","answers":{"binary":{"type":"noul","noul":0.9},"team":{"type":"choice","choice":"billing","probabilities":{"billing":1},"confidence":1},"priority":{"type":"score","score":1,"legend":{"0":"low","1":"high"},"probabilities":{"0":0,"1":1},"confidence":1}},"usage":{"input_tokens":20,"output_tokens":3}}""");
        using var client = FakeClient(handler);
        var response = await client.Decisions.CreateDecisionAsync(new DecisionRequest
        {
            Model = "mercury-decide", State = "Refund request",
            Questions = new()
            {
                ["binary"] = new NoulQuestion { Instructions = "Is this billing?" },
                ["team"] = new ChoiceQuestion { Criteria = Json("""{"billing":"Refunds"}""") },
                ["priority"] = new ScoreQuestion { Criteria = ["low", "high"] },
            },
        });
        response.Answers["binary"].Noul!.Noul.Should().Be(0.9);
        response.Answers["team"].Choice!.Choice.Should().Be("billing");
        response.Answers["priority"].Score!.Score.Should().Be(1);
        handler.Path.Should().Be("/v1/decisions");
        using var body = JsonDocument.Parse(handler.Body!);
        body.RootElement.GetProperty("questions").GetProperty("binary").GetProperty("type").GetString().Should().Be("noul");
        body.RootElement.GetProperty("questions").GetProperty("team").GetProperty("criteria").GetProperty("billing").GetString().Should().Be("Refunds");
        body.RootElement.GetProperty("questions").GetProperty("priority").GetProperty("type").GetString().Should().Be("score");
    }

    [TestMethod]
    public async Task FimAndEdit_UseTheirOwnEndpointsAndResponseTypes()
    {
        var handler = new Handler("""{"id":"fim-test","object":"text_completion","created":1,"model":"mercury-edit-2","choices":[{"index":0,"text":"a + b","finish_reason":"stop"}],"usage":USAGE}""".Replace("USAGE", UsageJson, StringComparison.Ordinal));
        using var client = FakeClient(handler);
        var fim = await client.Fim.CreateFimCompletionAsync(FimRequest());
        fim.Choices[0].Text.Should().Be("a + b");
        handler.Path.Should().Be("/v1/fim/completions");
        handler.Response = ChatJson.Replace("USAGE", UsageJson, StringComparison.Ordinal);
        var edit = await client.Edit.CreateEditCompletionAsync(new EditCompletionRequest
        {
            Model = "mercury-edit-2", Messages = [new EditMessageParam { Content = "<|code_to_edit|>x<|cursor|><|/code_to_edit|>" }],
        });
        edit.Choices[0].Message.Content?.Value1.Should().Be("Hello Dubai");
        handler.Path.Should().Be("/v1/edit/completions");
    }

    [TestMethod]
    public async Task NativeStreaming_PreservesReplacementDiffusionFrames()
    {
        var handler = new Handler(ChatEvent("noisy", null) + ChatEvent("final", "stop") + "data: [DONE]\n\n", true);
        using var client = FakeClient(handler);
        var request = ChatRequest();
        request.Stream = true;
        request.Diffusing = true;
        var frames = new List<string?>();
        await foreach (var chunk in client.Chat.CreateChatCompletionAsStreamAsync(request))
            frames.Add(chunk.Choices[0].Delta.Content);
        frames.Should().Equal("noisy", "final");
        using var body = JsonDocument.Parse(handler.Body!);
        body.RootElement.GetProperty("stream").GetBoolean().Should().BeTrue();
        body.RootElement.GetProperty("diffusing").GetBoolean().Should().BeTrue();
    }

    [TestMethod]
    public async Task FimStreaming_ReadsTextCompletionChunks()
    {
        var handler = new Handler("data: {\"id\":\"fim-test\",\"object\":\"text_completion\",\"created\":1,\"model\":\"mercury-edit-2\",\"choices\":[{\"index\":0,\"text\":\"a + b\",\"finish_reason\":\"stop\"}]}\n\ndata: [DONE]\n\n", true);
        using var client = FakeClient(handler);
        var request = FimRequest();
        request.Stream = true;
        var text = new StringBuilder();
        await foreach (var chunk in client.Fim.CreateFimCompletionAsStreamAsync(request)) text.Append(chunk.Choices[0].Text);
        text.ToString().Should().Be("a + b");
        handler.Path.Should().Be("/v1/fim/completions");
    }

    [TestMethod]
    public async Task AuthenticationFailure_PreservesHttpStatus()
    {
        var handler = new Handler("""{"error":{"message":"Invalid key","type":"authentication_error"}}""") { Status = HttpStatusCode.Unauthorized };
        using var client = FakeClient(handler);
        var action = async () => await client.Chat.CreateChatCompletionAsync(ChatRequest());
        var exception = await action.Should().ThrowAsync<ApiException>();
        exception.Which.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [TestMethod]
    public async Task Meai_MapsTextUsageLatencyOptionsAndMetadata()
    {
        var handler = new Handler(ChatJson.Replace("USAGE", UsageJson, StringComparison.Ordinal));
        using var native = FakeClient(handler);
        Meai.IChatClient client = native;
        var response = await client.GetResponseAsync([new Meai.ChatMessage(Meai.ChatRole.User, "hello")],
            new Meai.ChatOptions { AdditionalProperties = new() { ["reasoning_effort"] = "instant", ["realtime"] = true } });
        response.Text.Should().Be("Hello Dubai");
        response.Usage!.TotalTokenCount.Should().Be(6);
        response.Usage.AdditionalCounts!["InputTokenDetails.CachedTokenCount"].Should().Be(1);
        client.GetService(typeof(Meai.ChatClientMetadata)).Should().BeOfType<Meai.ChatClientMetadata>();
        using var body = JsonDocument.Parse(handler.Body!);
        body.RootElement.GetProperty("reasoning_effort").GetString().Should().Be("instant");
        body.RootElement.GetProperty("realtime").GetBoolean().Should().BeTrue();
    }

    [TestMethod]
    public async Task Meai_StreamsFragmentedToolCallsAndUsage()
    {
        var first = """{"id":"chat-test","created":1,"model":"mercury-3","object":"chat.completion.chunk","choices":[{"index":0,"delta":{"tool_calls":[{"index":0,"id":"call-1","function":{"name":"weather","arguments":"{\"city\":"}}]}}]}""";
        var second = """{"id":"chat-test","created":1,"model":"mercury-3","object":"chat.completion.chunk","choices":[{"index":0,"delta":{"tool_calls":[{"index":0,"function":{"arguments":"\"Dubai\"}"}}]},"finish_reason":"tool_calls"}]}""";
        var usage = """{"id":"chat-test","created":1,"model":"mercury-3","object":"chat.completion.chunk","choices":[],"usage":USAGE}""".Replace("USAGE", UsageJson, StringComparison.Ordinal);
        var handler = new Handler($"data: {first}\n\ndata: {second}\n\ndata: {usage}\n\ndata: [DONE]\n\n", true);
        using var native = FakeClient(handler);
        Meai.IChatClient client = native;
        var contents = new List<Meai.AIContent>();
        await foreach (var update in client.GetStreamingResponseAsync([new Meai.ChatMessage(Meai.ChatRole.User, "weather")]))
            contents.AddRange(update.Contents);
        var call = contents.OfType<Meai.FunctionCallContent>().Should().ContainSingle().Subject;
        call.CallId.Should().Be("call-1");
        call.Name.Should().Be("weather");
        ((JsonElement)call.Arguments!["city"]!).GetString().Should().Be("Dubai");
        contents.OfType<Meai.UsageContent>().Should().ContainSingle().Subject.Details.TotalTokenCount.Should().Be(6);
    }

    [TestMethod]
    public async Task Meai_RejectsDiffusionRatherThanConcatenatingReplacementFrames()
    {
        using var native = FakeClient(new Handler(string.Empty));
        Meai.IChatClient client = native;
        var action = async () => await client.GetResponseAsync([new Meai.ChatMessage(Meai.ChatRole.User, "hello")],
            new Meai.ChatOptions { AdditionalProperties = new() { ["diffusing"] = true } });
        await action.Should().ThrowAsync<NotSupportedException>();
    }

    private static string ChatEvent(string text, string? finish) =>
        "data: {\"id\":\"chat-test\",\"object\":\"chat.completion.chunk\",\"created\":1,\"model\":\"mercury-3\",\"choices\":[{\"index\":0,\"delta\":{\"content\":\"" + text + "\"},\"finish_reason\":" + (finish is null ? "null" : "\"" + finish + "\"") + "}]}\n\n";

    private static InceptionClient FakeClient(Handler handler) =>
        new("test-key", httpClient: new HttpClient(handler), baseUri: new Uri("https://example.test"));

    private sealed class Handler(string response, bool streaming = false) : HttpMessageHandler
    {
        public string Response { get; set; } = response;
        public HttpStatusCode Status { get; set; } = HttpStatusCode.OK;
        public string? Path { get; private set; }
        public string? Authorization { get; private set; }
        public string? Body { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Path = request.RequestUri!.AbsolutePath;
            Authorization = request.Headers.Authorization?.ToString();
            Body = request.Content is null ? null : await request.Content.ReadAsStringAsync(cancellationToken);
            return new HttpResponseMessage(Status)
            {
                Content = new StringContent(Response, Encoding.UTF8, streaming ? "text/event-stream" : "application/json"),
            };
        }
    }
}
