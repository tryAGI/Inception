using System.Text.Json;

namespace Inception.IntegrationTests;

public partial class Tests
{
    private static ChatCompletionRequest ChatRequest() => new()
    {
        Model = "mercury-3", Messages = [new Message { Role = MessageRole.User, Content = "Say hello in three words." }],
        MaxCompletionTokens = 1024, Temperature = 0.75,
        ReasoningEffort = ChatCompletionRequestReasoningEffort.Instant, Realtime = true,
    };

    private static ChatCompletionTool WeatherTool() => new()
    {
        Function = new FunctionDefinition
        {
            Name = "get_weather", Description = "Get the weather in a city.",
            Parameters = Json("""{"type":"object","properties":{"city":{"type":"string"}},"required":["city"],"additionalProperties":false}"""),
        },
    };

    private static JsonElement Json(string value)
    {
        using var document = JsonDocument.Parse(value);
        return document.RootElement.Clone();
    }

    private static FIMCompletionRequest FimRequest() => new()
    {
        Model = "mercury-edit-2", Prompt = "def add(a, b):\n    return ",
        Suffix = "\n\nprint(add(2, 3))", MaxTokens = 64,
    };
}
