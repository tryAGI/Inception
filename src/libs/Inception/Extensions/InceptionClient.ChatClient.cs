using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Meai = Microsoft.Extensions.AI;

namespace Inception;

public partial class InceptionClient : Meai.IChatClient
{
    private Meai.ChatClientMetadata? _metadata;

    /// <inheritdoc />
    object? Meai.IChatClient.GetService(Type serviceType, object? serviceKey) =>
        serviceKey is not null ? null :
        serviceType == typeof(Meai.ChatClientMetadata) ? _metadata ??= new(nameof(InceptionClient), BaseUri) :
        serviceType.IsInstanceOfType(this) ? this : null;

    async Task<Meai.ChatResponse> Meai.IChatClient.GetResponseAsync(
        IEnumerable<Meai.ChatMessage> messages, Meai.ChatOptions? options, CancellationToken cancellationToken)
    {
        var response = await Chat.CreateChatCompletionAsync(CreateRequest(messages, options, false),
            cancellationToken: cancellationToken).ConfigureAwait(false);
        var result = new List<Meai.ChatMessage>();
        foreach (var choice in response.Choices)
        {
            var message = new Meai.ChatMessage(Meai.ChatRole.Assistant, GetText(choice.Message))
            {
                RawRepresentation = choice.Message,
            };
            if (choice.Message.ToolCalls is { } calls)
            {
                foreach (var call in calls)
                {
                    message.Contents.Add(new Meai.FunctionCallContent(
                        call.Id, call.Function.Name ?? string.Empty, ParseArguments(call.Function.Arguments)));
                }
            }
            result.Add(message);
        }
        return new Meai.ChatResponse(result)
        {
            ResponseId = response.Id,
            ModelId = response.Model,
            CreatedAt = DateTimeOffset.FromUnixTimeSeconds(response.Created),
            FinishReason = FinishReason(response.Choices.FirstOrDefault()?.FinishReason?.ToValueString()),
            RawRepresentation = response,
            Usage = ConvertUsage(response.Usage),
        };
    }

    async IAsyncEnumerable<Meai.ChatResponseUpdate> Meai.IChatClient.GetStreamingResponseAsync(
        IEnumerable<Meai.ChatMessage> messages, Meai.ChatOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var calls = new Dictionary<(int Choice, int Tool), (string? Id, string? Name, StringBuilder Args)>();
        await foreach (var chunk in Chat.CreateChatCompletionAsStreamAsync(CreateRequest(messages, options, true),
            cancellationToken: cancellationToken).ConfigureAwait(false))
        {
            if (chunk.AdditionalProperties.TryGetValue("usage", out var rawUsage) && rawUsage is JsonElement usageElement && usageElement.ValueKind == JsonValueKind.Object)
            {
                var usage = Usage.FromJson(usageElement.GetRawText(), JsonSerializerContext);
                if (usage is not null)
                {
                    var update = new Meai.ChatResponseUpdate { ResponseId = chunk.Id, ModelId = chunk.Model };
                    update.Contents.Add(new Meai.UsageContent(ConvertUsage(usage)));
                    yield return update;
                }
            }
            foreach (var choice in chunk.Choices)
            {
                var update = new Meai.ChatResponseUpdate(Meai.ChatRole.Assistant, choice.Delta.Content)
                {
                    ResponseId = chunk.Id,
                    ModelId = chunk.Model,
                    CreatedAt = DateTimeOffset.FromUnixTimeSeconds(chunk.Created),
                    RawRepresentation = chunk,
                    FinishReason = FinishReason(choice.FinishReason?.ToValueString()),
                };
                if (choice.Delta.ToolCalls is { } deltas)
                {
                    foreach (var delta in deltas)
                    {
                        var key = (choice.Index, delta.Index ?? 0);
                        if (!calls.TryGetValue(key, out var call)) call = (null, null, new StringBuilder());
                        call.Id = delta.Id ?? call.Id;
                        call.Name = delta.Function?.Name ?? call.Name;
                        call.Args.Append(delta.Function?.Arguments);
                        calls[key] = call;
                    }
                }
                if (choice.FinishReason is not null)
                {
                    foreach (var key in calls.Keys.Where(key => key.Choice == choice.Index).ToArray())
                    {
                        var call = calls[key];
                        update.Contents.Add(new Meai.FunctionCallContent(call.Id ?? string.Empty,
                            call.Name ?? string.Empty, ParseArguments(call.Args.ToString())));
                        calls.Remove(key);
                    }
                }
                yield return update;
            }
        }
    }

    private ChatCompletionRequest CreateRequest(IEnumerable<Meai.ChatMessage> messages, Meai.ChatOptions? options, bool stream)
    {
        var request = options?.RawRepresentationFactory?.Invoke(this) as ChatCompletionRequest ?? new()
        {
            Model = options?.ModelId ?? "mercury-3",
            Messages = [],
        };
        request.Model = options?.ModelId ?? request.Model;
        request.Messages = [];
        request.Stream = stream;
        if (stream) request.StreamOptions = new StreamOptions { IncludeUsage = true };
        // Diffusion frames replace text rather than append deltas; IChatClient consumes append-only updates.
        if (request.Diffusing == true) throw new NotSupportedException("Use the native streaming API for diffusion frames.");
        foreach (var message in messages)
        {
            var role = message.Role == Meai.ChatRole.System ? MessageRole.System :
                message.Role == Meai.ChatRole.Assistant ? MessageRole.Assistant :
                message.Role == Meai.ChatRole.Tool ? MessageRole.Tool :
                message.Role == Meai.ChatRole.User ? MessageRole.User :
                throw new NotSupportedException($"Unsupported chat role: {message.Role}");
            if (message.Role == Meai.ChatRole.Tool)
            {
                if (message.Contents.Any(content => content is not Meai.FunctionResultContent))
                    throw new NotSupportedException("Tool messages require FunctionResultContent.");
                foreach (var result in message.Contents.OfType<Meai.FunctionResultContent>())
                {
                    request.Messages.Add(new Message
                    {
                        Role = role,
                        ToolCallId = result.CallId,
                        Content = result.Result is string text ? text : JsonValue(result.Result),
                    });
                }
                continue;
            }
            if (message.Contents.Any(content => content is not Meai.TextContent and not Meai.FunctionCallContent))
                throw new NotSupportedException("Mercury chat accepts text and function calls. Use native Decisions for image inputs.");
            var native = new Message { Role = role, Content = message.Text };
            var calls = message.Contents.OfType<Meai.FunctionCallContent>().ToArray();
            if (calls.Length > 0)
            {
                native.ToolCalls = calls.Select(call => new ToolCall
                {
                    Id = call.CallId,
                    Function = new FunctionCall
                    {
                        Name = call.Name,
                        Arguments = JsonValue(call.Arguments ?? new Dictionary<string, object?>()),
                    },
                }).ToList();
            }
            request.Messages.Add(native);
        }
        if (options is null) return request;
        request.Temperature = options.Temperature ?? request.Temperature;
        request.MaxCompletionTokens = options.MaxOutputTokens ?? request.MaxCompletionTokens;
        request.Stop = options.StopSequences?.ToList() ?? request.Stop;
        if (options.Seed is not null || options.TopP is not null || options.TopK is not null || options.FrequencyPenalty is not null || options.PresencePenalty is not null)
            throw new NotSupportedException("The Inception chat endpoint does not expose these sampling controls.");
        if (options.Tools is { Count: > 0 })
        {
            request.Tools = options.Tools.Select(tool => tool is Meai.AIFunctionDeclaration function
                ? new ChatCompletionTool
                {
                    Function = new FunctionDefinition
                    {
                        Name = function.Name,
                        Description = function.Description,
                        Parameters = function.JsonSchema.Clone(),
                    },
                }
                : throw new NotSupportedException("Only function tools are supported.")).ToList();
        }
        if (options.ToolMode is Meai.NoneChatToolMode) request.ToolChoice = ChatCompletionRequestToolChoice.None;
        else if (options.ToolMode is Meai.RequiredChatToolMode required)
            request.ToolChoice = required.RequiredFunctionName is { } name
                ? new NamedToolChoice { Function = new ToolChoiceFunction { Name = name } }
                : ChatCompletionRequestToolChoice.Required;
        else if (options.ToolMode is not null) request.ToolChoice = ChatCompletionRequestToolChoice.Auto;
        if (options.ResponseFormat is Meai.ChatResponseFormatJson json)
        {
            request.ResponseFormat = json.Schema is { } schema
                ? new ResponseFormatJSONSchema
                {
                    JsonSchema = new JSONSchema { Name = json.SchemaName ?? "response", Description = json.SchemaDescription, Schema = schema.Clone(), Strict = true },
                }
                : new ResponseFormatJSONObject();
        }
        if (options.AdditionalProperties is { } properties)
        {
            foreach (var (key, value) in properties)
            {
                switch (key)
                {
                    case "reasoning_effort" when value is ChatCompletionRequestReasoningEffort effort:
                        request.ReasoningEffort = effort;
                        break;
                    case "reasoning_effort" when value is string effort:
                        request.ReasoningEffort = ChatCompletionRequestReasoningEffortExtensions.ToEnum(effort)
                            ?? throw new ArgumentException("Unknown Inception reasoning effort.", nameof(options));
                        break;
                    case "realtime" when value is bool realtime: request.Realtime = realtime; break;
                    case "reasoning_summary" when value is bool summary: request.ReasoningSummary = summary; break;
                    case "reasoning_summary_wait" when value is bool wait: request.ReasoningSummaryWait = wait; break;
                    case "diffusing" when value is false: request.Diffusing = false; break;
                    case "diffusing": throw new NotSupportedException("Use the native streaming API for diffusion frames.");
                    default: throw new NotSupportedException($"Unsupported Inception chat option: {key}. Use RawRepresentationFactory for native options.");
                }
            }
        }
        return request;
    }

    private static Meai.UsageDetails ConvertUsage(Usage usage)
    {
        var result = new Meai.UsageDetails
        {
            InputTokenCount = usage.PromptTokens,
            OutputTokenCount = usage.CompletionTokens,
            TotalTokenCount = usage.TotalTokens,
            AdditionalCounts = new(),
        };
        if (usage.PromptTokensDetails.CachedTokens is { } cached)
            result.AdditionalCounts["InputTokenDetails.CachedTokenCount"] = cached;
        if (usage.CompletionTokensDetails.ReasoningTokens is { } reasoning)
            result.AdditionalCounts["OutputTokenDetails.ReasoningTokenCount"] = reasoning;
        return result;
    }

    private static string GetText(Message message) => message.Content?.Value1 ?? string.Empty;

    private static Meai.ChatFinishReason? FinishReason(string? value) => value switch
    {
        null => null,
        "stop" => Meai.ChatFinishReason.Stop,
        "length" => Meai.ChatFinishReason.Length,
        "tool_calls" => Meai.ChatFinishReason.ToolCalls,
        _ => new Meai.ChatFinishReason(value),
    };

    private static Dictionary<string, object?>? ParseArguments(string json)
    {
        if (string.IsNullOrWhiteSpace(json)) return null;
        using var document = JsonDocument.Parse(json);
        return document.RootElement.EnumerateObject().ToDictionary(property => property.Name,
            property => (object?)property.Value.Clone(), StringComparer.Ordinal);
    }

    private static string JsonValue(object? value) =>
        JsonSerializer.Serialize(value, MeaiJsonContext.Default.Object);
}

[JsonSerializable(typeof(Dictionary<string, object?>))]
[JsonSerializable(typeof(JsonElement))]
[JsonSerializable(typeof(string))]
[JsonSerializable(typeof(bool))]
[JsonSerializable(typeof(int))]
[JsonSerializable(typeof(long))]
[JsonSerializable(typeof(double))]
[JsonSerializable(typeof(float))]
[JsonSerializable(typeof(decimal))]
[JsonSerializable(typeof(List<object?>))]
[JsonSerializable(typeof(object[]))]
internal sealed partial class MeaiJsonContext : JsonSerializerContext;
