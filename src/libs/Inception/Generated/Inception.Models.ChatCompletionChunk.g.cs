
#nullable enable

namespace Inception
{
    /// <summary>
    /// Model for a single chunk in a streaming chat completion response.
    /// </summary>
    public sealed partial class ChatCompletionChunk
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: chat.completion.chunk
        /// </summary>
        /// <default>"chat.completion.chunk"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "chat.completion.chunk";

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
        public required global::System.Collections.Generic.IList<global::Inception.ChunkChoice> Choices { get; set; }

        /// <summary>
        /// Summary of reasoning process (included in final chunk if available).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_summary")]
        public global::Inception.ReasoningSummary? ReasoningSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunk" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="created"></param>
        /// <param name="model"></param>
        /// <param name="choices"></param>
        /// <param name="reasoningSummary">
        /// Summary of reasoning process (included in final chunk if available).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="object">
        /// Default Value: chat.completion.chunk
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionChunk(
            string id,
            int created,
            string model,
            global::System.Collections.Generic.IList<global::Inception.ChunkChoice> choices,
            global::Inception.ReasoningSummary? reasoningSummary,
            string @object = "chat.completion.chunk")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Created = created;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.ReasoningSummary = reasoningSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunk" /> class.
        /// </summary>
        public ChatCompletionChunk()
        {
        }

    }
}