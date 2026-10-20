# Chat

Inception Chat example.

This example assumes `using Inception;` is in scope and `apiKey` contains your Inception API key.

```csharp
using var client = new InceptionClient(apiKey);
// `instant` and `realtime` reduce the time to first answer text.
var response = await client.Chat.CreateChatCompletionAsync(new ChatCompletionRequest
{
    Model = "mercury-3",
    Messages = [new Message { Role = MessageRole.User, Content = "Say hello in three words." }],
    ReasoningEffort = ChatCompletionRequestReasoningEffort.Instant,
    Realtime = true, Temperature = 0.75, MaxCompletionTokens = 1024,
});
```