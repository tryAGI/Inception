# Fim

Inception Fim example.

This example assumes `using Inception;` is in scope and `apiKey` contains your Inception API key.

```csharp
using var client = new InceptionClient(apiKey);
var response = await client.Fim.CreateFimCompletionAsync(new FIMCompletionRequest
{
    Model = "mercury-edit-2", Prompt = "def add(a, b):\n    return ",
    Suffix = "\n\nprint(add(2, 3))", MaxTokens = 64,
});
```