# ToolCalling

Inception ToolCalling example.

This example assumes `using Inception;` is in scope and `apiKey` contains your Inception API key.

```csharp
using var client = new InceptionClient(apiKey);
var request = new ChatCompletionRequest
{
    Model = "mercury-3",
    Messages = [new Message { Role = MessageRole.User, Content = "Say hello in three words." }],
    ReasoningEffort = ChatCompletionRequestReasoningEffort.Instant,
    Realtime = true, Temperature = 0.75, MaxCompletionTokens = 1024,
};
request.Messages = [new Message { Role = MessageRole.User, Content = "Get the weather in Dubai." }];
request.Tools = [WeatherTool()];
request.ToolChoice = new NamedToolChoice { Function = new ToolChoiceFunction { Name = "get_weather" } };
var response = await client.Chat.CreateChatCompletionAsync(request);
var call = response.Choices[0].Message.ToolCalls![0];
using var arguments = JsonDocument.Parse(call.Function.Arguments);
```