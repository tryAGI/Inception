
#nullable enable

namespace Inception
{
    /// <summary>
    /// Choice for FIM completions.
    /// </summary>
    public sealed partial class TextCompletionChoice
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The reason the model stopped generating tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inception.JsonConverters.TextCompletionChoiceFinishReasonJsonConverter))]
        public global::Inception.TextCompletionChoiceFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCompletionChoice" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="text"></param>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextCompletionChoice(
            int index,
            string text,
            global::Inception.TextCompletionChoiceFinishReason? finishReason)
        {
            this.Index = index;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCompletionChoice" /> class.
        /// </summary>
        public TextCompletionChoice()
        {
        }

    }
}