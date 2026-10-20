
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Inception.Message> Messages { get; set; }

        /// <summary>
        /// The model to use for the chat completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate. Deprecated in favour of `max_completion_tokens`, which takes precedence when both are supplied. The maximum depends on `model`: 50,000 for `mercury-2`; 65,536 for `mercury-2.5`; 131,072 for `mercury-3`. When neither token-budget field is supplied: For `mercury-2`, the default is 16,384. For `mercury-2.5`, the default is 16,384; 65,536 when `reasoning_effort="high"`. For `mercury-3`, the default is 24,576; 8,192 when `reasoning_effort="instant"`; 65,536 when `reasoning_effort="medium"`; 131,072 when `reasoning_effort="high"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// An upper bound for the number of tokens that can be generated for a completion, including visible output tokens and reasoning tokens. Supersedes `max_tokens`. When neither field is supplied, the model's configured default applies (16384 for `mercury-2`). The maximum depends on `model`: 50,000 for `mercury-2`; 65,536 for `mercury-2.5`; 131,072 for `mercury-3`. When neither token-budget field is supplied: For `mercury-2`, the default is 16,384. For `mercury-2.5`, the default is 16,384; 65,536 when `reasoning_effort="high"`. For `mercury-3`, the default is 24,576; 8,192 when `reasoning_effort="instant"`; 65,536 when `reasoning_effort="medium"`; 131,072 when `reasoning_effort="high"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0.5 and 1. Higher values make the output more random; lower values make it more focused and deterministic. For `mercury-2`, the default is 0.75; out-of-range values are reset to 0.75 with a `warning` in the response. For `mercury-2.5`, the default is 1; out-of-range values are reset to 1 with a `warning` in the response. For `mercury-3`, the default is 1; out-of-range values are reset to 1 with a `warning` in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// A list of sequences where the API will stop generating further tokens. The returned text will not contain the stop sequences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// A list of tools the model may call. Use this to provide functions the model can generate JSON arguments for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Inception.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Controls tool selection: 'auto' (model decides, default when tools present), 'required' (model must call one), 'none' (model must not call one), or {"type": "function", "function": {"name": "..."}} to force one declared tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inception.JsonConverters.AnyOfJsonConverter<global::Inception.ChatCompletionRequestToolChoice?, global::Inception.NamedToolChoice>))]
        public global::Inception.AnyOf<global::Inception.ChatCompletionRequestToolChoice?, global::Inception.NamedToolChoice>? ToolChoice { get; set; }

        /// <summary>
        /// Whether to stream the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Options that control streaming behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::Inception.StreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// Whether to show the diffusion effect in the streamed response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diffusing")]
        public bool? Diffusing { get; set; }

        /// <summary>
        /// Extra parameters passed to the model (OpenAI-compat passthrough).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_body")]
        public object? ExtraBody { get; set; }

        /// <summary>
        /// Enable flag for more realtime workloads that require lower TTFT/TTFAT.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realtime")]
        public bool? Realtime { get; set; }

        /// <summary>
        /// An object specifying the format that the model must output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inception.JsonConverters.OneOfJsonConverter<global::Inception.ResponseFormatText, global::Inception.ResponseFormatJSONObject, global::Inception.ResponseFormatJSONSchema>))]
        public global::Inception.OneOf<global::Inception.ResponseFormatText, global::Inception.ResponseFormatJSONObject, global::Inception.ResponseFormatJSONSchema>? ResponseFormat { get; set; }

        /// <summary>
        /// Request a summary of the model's reasoning process.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_summary")]
        public bool? ReasoningSummary { get; set; }

        /// <summary>
        /// Wait for all reasoning summaries to complete before finishing the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_summary_wait")]
        public bool? ReasoningSummaryWait { get; set; }

        /// <summary>
        /// Constrains the effort spent on reasoning before the model responds.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inception.JsonConverters.ChatCompletionRequestReasoningEffortJsonConverter))]
        public global::Inception.ChatCompletionRequestReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="model">
        /// The model to use for the chat completion.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// An upper bound for the number of tokens that can be generated for a completion, including visible output tokens and reasoning tokens. Supersedes `max_tokens`. When neither field is supplied, the model's configured default applies (16384 for `mercury-2`). The maximum depends on `model`: 50,000 for `mercury-2`; 65,536 for `mercury-2.5`; 131,072 for `mercury-3`. When neither token-budget field is supplied: For `mercury-2`, the default is 16,384. For `mercury-2.5`, the default is 16,384; 65,536 when `reasoning_effort="high"`. For `mercury-3`, the default is 24,576; 8,192 when `reasoning_effort="instant"`; 65,536 when `reasoning_effort="medium"`; 131,072 when `reasoning_effort="high"`.
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0.5 and 1. Higher values make the output more random; lower values make it more focused and deterministic. For `mercury-2`, the default is 0.75; out-of-range values are reset to 0.75 with a `warning` in the response. For `mercury-2.5`, the default is 1; out-of-range values are reset to 1 with a `warning` in the response. For `mercury-3`, the default is 1; out-of-range values are reset to 1 with a `warning` in the response.
        /// </param>
        /// <param name="stop">
        /// A list of sequences where the API will stop generating further tokens. The returned text will not contain the stop sequences.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Use this to provide functions the model can generate JSON arguments for.
        /// </param>
        /// <param name="toolChoice">
        /// Controls tool selection: 'auto' (model decides, default when tools present), 'required' (model must call one), 'none' (model must not call one), or {"type": "function", "function": {"name": "..."}} to force one declared tool.
        /// </param>
        /// <param name="stream">
        /// Whether to stream the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions">
        /// Options that control streaming behavior.
        /// </param>
        /// <param name="diffusing">
        /// Whether to show the diffusion effect in the streamed response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="extraBody">
        /// Extra parameters passed to the model (OpenAI-compat passthrough).
        /// </param>
        /// <param name="realtime">
        /// Enable flag for more realtime workloads that require lower TTFT/TTFAT.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output.
        /// </param>
        /// <param name="reasoningSummary">
        /// Request a summary of the model's reasoning process.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="reasoningSummaryWait">
        /// Wait for all reasoning summaries to complete before finishing the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="reasoningEffort">
        /// Constrains the effort spent on reasoning before the model responds.<br/>
        /// Default Value: medium
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequest(
            global::System.Collections.Generic.IList<global::Inception.Message> messages,
            string model,
            int? maxCompletionTokens,
            double? temperature,
            global::System.Collections.Generic.IList<string>? stop,
            global::System.Collections.Generic.IList<global::Inception.ChatCompletionTool>? tools,
            global::Inception.AnyOf<global::Inception.ChatCompletionRequestToolChoice?, global::Inception.NamedToolChoice>? toolChoice,
            bool? stream,
            global::Inception.StreamOptions? streamOptions,
            bool? diffusing,
            object? extraBody,
            bool? realtime,
            global::Inception.OneOf<global::Inception.ResponseFormatText, global::Inception.ResponseFormatJSONObject, global::Inception.ResponseFormatJSONSchema>? responseFormat,
            bool? reasoningSummary,
            bool? reasoningSummaryWait,
            global::Inception.ChatCompletionRequestReasoningEffort? reasoningEffort)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.MaxCompletionTokens = maxCompletionTokens;
            this.Temperature = temperature;
            this.Stop = stop;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Diffusing = diffusing;
            this.ExtraBody = extraBody;
            this.Realtime = realtime;
            this.ResponseFormat = responseFormat;
            this.ReasoningSummary = reasoningSummary;
            this.ReasoningSummaryWait = reasoningSummaryWait;
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        public ChatCompletionRequest()
        {
        }

    }
}