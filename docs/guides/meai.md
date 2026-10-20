# Microsoft.Extensions.AI

Install `tryAGI.Inception`. The client directly implements `IChatClient`:

```csharp
using Inception;
using Microsoft.Extensions.AI;

using var native = new InceptionClient(
    Environment.GetEnvironmentVariable("INCEPTION_API_KEY")!);
Microsoft.Extensions.AI.IChatClient client = native;
var response = await client.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Say hello in three words.")],
    new ChatOptions
    {
        ModelId = "mercury-3",
        MaxOutputTokens = 1024,
        AdditionalProperties = new()
        {
            ["reasoning_effort"] = "instant",
            ["realtime"] = true,
        },
    });
Console.WriteLine(response.Text);
```

The adapter supports text, streamed text, function calls/results, required or named
function selection, JSON object/schema responses, temperature, maximum completion
tokens, stop sequences, usage, and provider metadata. Native reasoning controls
`reasoning_effort`, `realtime`, `reasoning_summary`, and `reasoning_summary_wait`
are accepted through `AdditionalProperties`. `RawRepresentationFactory` can return
a `ChatCompletionRequest` for other native options.

Unsupported roles, content, and sampling controls raise `NotSupportedException`
rather than disappear from the request. Diffusion frames replace the prior text;
use `native.Chat.CreateChatCompletionAsStreamAsync` to handle them explicitly.
The adapter rejects diffusion mode because MEAI streaming expects append-only text.

Use the native `Decisions`, `Fim`, `Edit`, and `Models` clients for non-chat APIs.
