# FimStreaming

Inception FimStreaming example.

This example assumes `using Inception;` is in scope and `apiKey` contains your Inception API key.

```csharp
using var client = new InceptionClient(apiKey);
var request = new FIMCompletionRequest
{
    Model = "mercury-edit-2", Prompt = "def add(a, b):\n    return ",
    Suffix = "\n\nprint(add(2, 3))", MaxTokens = 64,
};
request.Stream = true;
var text = new StringBuilder();
await foreach (var chunk in client.Fim.CreateFimCompletionAsStreamAsync(request))
    foreach (var choice in chunk.Choices) text.Append(choice.Text);
```