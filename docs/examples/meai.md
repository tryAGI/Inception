# Microsoft.Extensions.AI

Use Mercury chat through IChatClient with native low-latency options.

This example assumes `using Inception;` is in scope and `apiKey` contains your Inception API key.

```csharp
using var native = new InceptionClient(apiKey);
Meai.IChatClient client = native;
var options = new Meai.ChatOptions
{
    ModelId = "mercury-3", MaxOutputTokens = 1024,
    AdditionalProperties = new() { ["reasoning_effort"] = "instant", ["realtime"] = true },
};
if (streaming)
{
    var text = new System.Text.StringBuilder();
    await foreach (var update in client.GetStreamingResponseAsync([new Meai.ChatMessage(Meai.ChatRole.User, "Say hello in three words.")], options))
        text.Append(update.Text);
}
else
{
    var response = await client.GetResponseAsync([new Meai.ChatMessage(Meai.ChatRole.User, "Say hello in three words.")], options);
}
```