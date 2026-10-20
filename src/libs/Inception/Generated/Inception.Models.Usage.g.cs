
#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Usage
    {
        /// <summary>
        /// Number of tokens in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Number of tokens in the generated completion, including reasoning tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        /// Total tokens used in the request (prompt + completion).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Breakdown of the tokens in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inception.PromptTokensDetails PromptTokensDetails { get; set; }

        /// <summary>
        /// Breakdown of the tokens generated for the completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inception.CompletionTokensDetails CompletionTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Number of tokens in the prompt.
        /// </param>
        /// <param name="completionTokens">
        /// Number of tokens in the generated completion, including reasoning tokens.
        /// </param>
        /// <param name="totalTokens">
        /// Total tokens used in the request (prompt + completion).
        /// </param>
        /// <param name="promptTokensDetails">
        /// Breakdown of the tokens in the prompt.
        /// </param>
        /// <param name="completionTokensDetails">
        /// Breakdown of the tokens generated for the completion.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Usage(
            int promptTokens,
            int completionTokens,
            int totalTokens,
            global::Inception.PromptTokensDetails promptTokensDetails,
            global::Inception.CompletionTokensDetails completionTokensDetails)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.PromptTokensDetails = promptTokensDetails ?? throw new global::System.ArgumentNullException(nameof(promptTokensDetails));
            this.CompletionTokensDetails = completionTokensDetails ?? throw new global::System.ArgumentNullException(nameof(completionTokensDetails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }

    }
}