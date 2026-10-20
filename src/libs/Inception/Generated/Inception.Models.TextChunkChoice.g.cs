
#nullable enable

namespace Inception
{
    /// <summary>
    /// Represents a choice in a streaming text completion response chunk.
    /// </summary>
    public sealed partial class TextChunkChoice
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The text in this chunk.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The reason the model stopped generating tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inception.JsonConverters.TextChunkChoiceFinishReasonJsonConverter))]
        public global::Inception.TextChunkChoiceFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextChunkChoice" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="text">
        /// The text in this chunk.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextChunkChoice(
            int index,
            string? text,
            global::Inception.TextChunkChoiceFinishReason? finishReason)
        {
            this.Index = index;
            this.Text = text;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextChunkChoice" /> class.
        /// </summary>
        public TextChunkChoice()
        {
        }

    }
}