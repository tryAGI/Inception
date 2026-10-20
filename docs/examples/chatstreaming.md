# ChatStreaming

Inception ChatStreaming example.

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
request.Stream = true;
var text = new StringBuilder();
await foreach (var chunk in client.Chat.CreateChatCompletionAsStreamAsync(request))
    foreach (var choice in chunk.Choices) text.Append(choice.Delta.Content);
```