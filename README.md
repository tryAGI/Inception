<div class="docs-hero">
  <h1>Inception</h1>
  <p class="docs-hero-lead">Typed .NET 10 SDK for Mercury chat, decisions, code autocomplete, and predictive edits.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/tryAGI.Inception/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/tryAGI.Inception"></a>
    <a href="https://github.com/tryAGI/Inception/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/Inception/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/Inception/blob/main/LICENSE"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/Inception"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from <a href="https://api.inceptionlabs.ai/openapi.json">Inception's OpenAPI definition</a> so the SDK stays close to the upstream API surface.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Installation

```sh
dotnet add package tryAGI.Inception --prerelease
```

## Usage

```csharp
using Inception;

using var client = new InceptionClient(
    Environment.GetEnvironmentVariable("INCEPTION_API_KEY")!);
var response = await client.Chat.CreateChatCompletionAsync(new ChatCompletionRequest
{
    Model = "mercury-3",
    Messages = [new Message { Role = MessageRole.User, Content = "Hello from Dubai!" }],
    ReasoningEffort = ChatCompletionRequestReasoningEffort.Instant,
    Realtime = true,
    Temperature = 0.75,
    MaxCompletionTokens = 1024,
});
Console.WriteLine(response.Choices[0].Message.Content?.Value1);
```

## API coverage

| Client | Operations |
| --- | --- |
| `Chat` | Chat completion and SSE streaming, tool calling, structured output, typed reasoning/realtime controls, native diffusion frames |
| `Decisions` | Named binary (`noul`), choice, and score questions with typed answer unions |
| `Fim` | Fill-in-the-middle code completion and SSE streaming |
| `Edit` | Predictive code edits |
| `Models` | General, chat, FIM, and edit model catalogs, including context, pricing, and capabilities |

All eight operations in [Inception's official OpenAPI document](https://api.inceptionlabs.ai/openapi.json)
are generated. The general model catalog can omit code models; query the FIM/edit catalogs too.

## Microsoft.Extensions.AI

`InceptionClient` implements `Microsoft.Extensions.AI.IChatClient` directly for text,
streaming, function tools, JSON schemas, token usage, and native latency options.
See the [MEAI guide](https://tryagi.github.io/Inception/guides/meai/).
Use the native API for Decisions, code endpoints, and diffusion frames. Diffusion
frames replace prior text rather than append; the MEAI adapter rejects this mode.
Mercury chat is text-only; the public API does not provide an audio/WebRTC transport.

## Development and verification

```sh
dotnet test Inception.slnx --filter 'TestCategory!=Live'
# With INCEPTION_API_KEY exported, exercise all endpoints and both streaming APIs:
dotnet test Inception.slnx --filter 'TestCategory=Live'
bash src/libs/Inception/generate.sh
dotnet tool run autosdk -- trim src/libs/Inception/Inception.csproj
```

Live tests consume provider credits and skip if the key is missing or empty. Local
`.env` files are ignored and are not loaded automatically. CI accepts an optional
`INCEPTION_API_KEY` repository secret for live checks. The publishing workflow
always runs deterministic checks; it does not require a provider key.

Regeneration uses pinned AutoSDK and preserves the original contract in
`openapi.upstream.json`. The preparation step promotes the two inline Decisions
unions to named references so the generator preserves typed dictionaries. No
wire fields or endpoints are removed. The generated API contract remains governed
by Inception's terms; the SDK implementation is MIT licensed.

## Dependencies

Consumer runtime code uses .NET 10 and Microsoft's `Microsoft.Extensions.AI.Abstractions`.
AutoSDK, MinVer, and reproducible-build tooling are development dependencies;
MSTest and AwesomeAssertions are test dependencies. No OpenAI SDK dependency is required. See [dependency accounting](https://github.com/tryAGI/Inception/blob/main/DEPENDENCIES.md).

CI also publishes and runs an offline NativeAOT executable covering Decisions,
MEAI tool arguments/results, usage, and SSE before the publishing workflow starts.

<!-- EXAMPLES:START -->
### Chat
Inception Chat example.

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

### ChatStreaming
Inception ChatStreaming example.

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

### StructuredOutput
Inception StructuredOutput example.

```csharp
using var client = new InceptionClient(apiKey);
var request = new ChatCompletionRequest
{
    Model = "mercury-3",
    Messages = [new Message { Role = MessageRole.User, Content = "Say hello in three words." }],
    ReasoningEffort = ChatCompletionRequestReasoningEffort.Instant,
    Realtime = true, Temperature = 0.75, MaxCompletionTokens = 1024,
};
request.Messages = [new Message { Role = MessageRole.User, Content = "Return the city Dubai as JSON." }];
request.ResponseFormat = new ResponseFormatJSONSchema
{
    JsonSchema = new JSONSchema
    {
        Name = "city_response", Strict = true,
        Schema = Json("""{"type":"object","properties":{"city":{"type":"string"}},"required":["city"],"additionalProperties":false}"""),
    },
};
var response = await client.Chat.CreateChatCompletionAsync(request);
using var result = JsonDocument.Parse(response.Choices[0].Message.Content!.Value.Value1!);
```

### ToolCalling
Inception ToolCalling example.

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

### Typed decisions
Classify shared state with binary probability, named choices, and ordinal scores.

```csharp
using var client = new InceptionClient(apiKey);
// Inception uses named dictionaries rather than OpenAI's question arrays.
var response = await client.Decisions.CreateDecisionAsync(new DecisionRequest
{
    Model = "mercury-decide", State = "Please refund the duplicate charge on my account.",
    Questions = new()
    {
        ["billing"] = new NoulQuestion { Instructions = "Is this request about billing?" },
        ["team"] = new ChoiceQuestion
        {
            Criteria = Json("""{"billing":"Payments and refunds","support":"Technical problems"}"""),
        },
        ["urgency"] = new ScoreQuestion
        {
            Instructions = "How urgent is this request?", Criteria = ["Can wait", "Needs attention", "Immediate emergency"],
        },
    },
});
```

### Fim
Inception Fim example.

```csharp
using var client = new InceptionClient(apiKey);
var response = await client.Fim.CreateFimCompletionAsync(new FIMCompletionRequest
{
    Model = "mercury-edit-2", Prompt = "def add(a, b):\n    return ",
    Suffix = "\n\nprint(add(2, 3))", MaxTokens = 64,
});
```

### FimStreaming
Inception FimStreaming example.

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

### Edit
Inception Edit example.

```csharp
using var client = new InceptionClient(apiKey);
var response = await client.Edit.CreateEditCompletionAsync(new EditCompletionRequest
{
    Model = "mercury-edit-2", MaxTokens = 256,
    Messages = [new EditMessageParam
    {
        Content = "<|recently_viewed_code_snippets|>\n\n<|/recently_viewed_code_snippets|>\n<|current_file_content|>\ncurrent_file_path: add.py\n<|code_to_edit|>\ndef add(a, b):\n    return a - b<|cursor|>\n<|/code_to_edit|>\n<|/current_file_content|>\n<|edit_diff_history|>\n# Implement addition rather than subtraction.\n<|/edit_diff_history|>",
    }],
});
```

### Model catalogs
Discover models, context limits, pricing, and capabilities in every catalog.

```csharp
using var client = new InceptionClient(apiKey);
var response = catalog switch
{
    "chat" => await client.Models.ListChatModelsAsync(),
    "fim" => await client.Models.ListFIMModelsAsync(),
    "edit" => await client.Models.ListEditModelsAsync(),
    _ => await client.Models.ListModelsAsync(),
};
foreach (var model in response.Data)
{
}
// Query filtered catalogs too: the general catalog may omit Mercury Edit 2.
```

### Microsoft.Extensions.AI
Use Mercury chat through IChatClient with native low-latency options.

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
<!-- EXAMPLES:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/Inception/issues">tryAGI/Inception</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/Inception/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
