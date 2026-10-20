using System.Text.Json;
using Meai = Microsoft.Extensions.AI;

namespace Inception.IntegrationTests;

public partial class Tests
{
    private static Meai.AIFunctionDeclaration WeatherDeclaration() => Meai.AIFunctionFactory.CreateDeclaration(
        "get_weather", "Get the weather for a city.",
        Json("""{"type":"object","properties":{"city":{"type":"string"}},"required":["city"],"additionalProperties":false}"""));

    [TestMethod]
    public async Task Meai_MapsToolsHistoryAndJsonSchema()
    {
        var handler = new Handler(ChatJson.Replace("USAGE", UsageJson, StringComparison.Ordinal));
        using var native = FakeClient(handler);
        Meai.IChatClient client = native;
        var call = new Meai.ChatMessage(Meai.ChatRole.Assistant, [new Meai.FunctionCallContent("call-1", "get_weather", new Dictionary<string, object?> { ["city"] = "Dubai" })]);
        var result = new Meai.ChatMessage(Meai.ChatRole.Tool, [new Meai.FunctionResultContent("call-1", new Dictionary<string, object?> { ["temperature"] = 30, ["conditions"] = new object[] { "sunny", true } })]);
        await client.GetResponseAsync([call, result], new Meai.ChatOptions
        {
            Tools = [WeatherDeclaration()], ToolMode = Meai.ChatToolMode.RequireSpecific("get_weather"),
            ResponseFormat = new Meai.ChatResponseFormatJson(Json("""{"type":"object","properties":{"city":{"type":"string"}},"required":["city"],"additionalProperties":false}"""), "city_response"),
        });
        using var body = JsonDocument.Parse(handler.Body!);
        var root = body.RootElement;
        root.GetProperty("tools")[0].GetProperty("function").GetProperty("name").GetString().Should().Be("get_weather");
        root.GetProperty("tool_choice").GetProperty("function").GetProperty("name").GetString().Should().Be("get_weather");
        root.GetProperty("messages")[1].GetProperty("tool_call_id").GetString().Should().Be("call-1");
        using var arguments = JsonDocument.Parse(root.GetProperty("messages")[0].GetProperty("tool_calls")[0].GetProperty("function").GetProperty("arguments").GetString()!);
        arguments.RootElement.GetProperty("city").GetString().Should().Be("Dubai");
        using var output = JsonDocument.Parse(root.GetProperty("messages")[1].GetProperty("content").GetString()!);
        output.RootElement.GetProperty("temperature").GetInt32().Should().Be(30);
        root.GetProperty("response_format").GetProperty("json_schema").GetProperty("name").GetString().Should().Be("city_response");
    }

    [TestMethod, TestCategory("Live")]
    [DataRow(false)]
    [DataRow(true)]
    public async Task Meai_LiveToolCalling(bool streaming)
    {
        using var native = GetAuthenticatedClient();
        Meai.IChatClient client = native;
        var options = new Meai.ChatOptions
        {
            MaxOutputTokens = 1024, Tools = [WeatherDeclaration()], ToolMode = Meai.ChatToolMode.RequireSpecific("get_weather"),
            AdditionalProperties = new() { ["reasoning_effort"] = "instant", ["realtime"] = true },
        };
        var messages = new[] { new Meai.ChatMessage(Meai.ChatRole.User, "Get the weather in Dubai.") };
        var calls = new List<Meai.FunctionCallContent>();
        if (streaming)
        {
            await foreach (var update in client.GetStreamingResponseAsync(messages, options))
                calls.AddRange(update.Contents.OfType<Meai.FunctionCallContent>());
        }
        else
        {
            var response = await client.GetResponseAsync(messages, options);
            calls.AddRange(response.Messages.SelectMany(message => message.Contents).OfType<Meai.FunctionCallContent>());
        }
        calls.Should().ContainSingle();
        calls[0].Name.Should().Be("get_weather");
        ((JsonElement)calls[0].Arguments!["city"]!).GetString().Should().Be("Dubai");
    }
}
