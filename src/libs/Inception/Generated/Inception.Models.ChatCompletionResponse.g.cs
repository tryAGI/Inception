
#nullable enable

namespace Inception
{
    /// <summary>
    /// Example: {"id":"chatcmpl-7a2b3c4d5e","object":"chat.completion","created":1745798400,"model":"mercury-2.5","choices":[{"index":0,"finish_reason":"stop","message":{"role":"assistant","content":"A diffusion language model is a type of language model that uses diffusion to generate text."}}],"usage":{"prompt_tokens":12,"completion_tokens":8,"total_tokens":20,"reasoning_tokens":0,"cached_input_tokens":0}}
    /// </summary>
    public sealed partial class ChatCompletionResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: chat.completion
        /// </summary>
        /// <default>"chat.completion"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "chat.completion";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Inception.Choice> Choices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inception.Usage Usage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning")]
        public string? Warning { get; set; }

        /// <summary>
        /// Summary of reasoning process if requested and available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_summary")]
        public global::Inception.ReasoningSummary? ReasoningSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="created"></param>
        /// <param name="model"></param>
        /// <param name="choices"></param>
        /// <param name="usage"></param>
        /// <param name="warning"></param>
        /// <param name="reasoningSummary">
        /// Summary of reasoning process if requested and available.
        /// </param>
        /// <param name="object">
        /// Default Value: chat.completion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponse(
            string id,
            int created,
            string model,
            global::System.Collections.Generic.IList<global::Inception.Choice> choices,
            global::Inception.Usage usage,
            string? warning,
            global::Inception.ReasoningSummary? reasoningSummary,
            string @object = "chat.completion")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Created = created;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Warning = warning;
            this.ReasoningSummary = reasoningSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        public ChatCompletionResponse()
        {
        }

    }
}