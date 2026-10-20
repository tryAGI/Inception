
#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FIMCompletionRequest
    {
        /// <summary>
        /// The prompt to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The suffix to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// The model to use for the FIM completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 512
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Float that controls the cumulative probability of the top tokens to consider.<br/>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Limits sampling to the `k` most likely tokens. Must be `-1` (disables the cutoff and considers all tokens) or an integer from 1 to 1000; other values such as 0 are rejected.<br/>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Number between -2 and 2. Positive values penalize tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Number between -2 and 2. Positive values penalize tokens based on whether they have appeared in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 1.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Penalizes tokens that have already appeared in the generated text. Must be greater than 0. Values greater than 1.0 discourage repetition; 1.0 applies no penalty.<br/>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetition_penalty")]
        public double? RepetitionPenalty { get; set; }

        /// <summary>
        /// A list of sequences where the API will stop generating further tokens. The returned text will not contain the stop sequences. Defaults to common code-block boundaries.<br/>
        /// Default Value: [, ]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FIMCompletionRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to complete.
        /// </param>
        /// <param name="model">
        /// The model to use for the FIM completion.
        /// </param>
        /// <param name="suffix">
        /// The suffix to complete.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="topP">
        /// Float that controls the cumulative probability of the top tokens to consider.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="topK">
        /// Limits sampling to the `k` most likely tokens. Must be `-1` (disables the cutoff and considers all tokens) or an integer from 1 to 1000; other values such as 0 are rejected.<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="frequencyPenalty">
        /// Number between -2 and 2. Positive values penalize tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="presencePenalty">
        /// Number between -2 and 2. Positive values penalize tokens based on whether they have appeared in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 1.5F
        /// </param>
        /// <param name="repetitionPenalty">
        /// Penalizes tokens that have already appeared in the generated text. Must be greater than 0. Values greater than 1.0 discourage repetition; 1.0 applies no penalty.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="stop">
        /// A list of sequences where the API will stop generating further tokens. The returned text will not contain the stop sequences. Defaults to common code-block boundaries.<br/>
        /// Default Value: [, ]
        /// </param>
        /// <param name="stream">
        /// Whether to stream the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions">
        /// Options that control streaming behavior.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FIMCompletionRequest(
            string prompt,
            string model,
            string? suffix,
            int? maxTokens,
            double? topP,
            int? topK,
            double? frequencyPenalty,
            double? presencePenalty,
            double? repetitionPenalty,
            global::System.Collections.Generic.IList<string>? stop,
            bool? stream,
            global::Inception.StreamOptions? streamOptions)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Suffix = suffix;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.MaxTokens = maxTokens;
            this.TopP = topP;
            this.TopK = topK;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.RepetitionPenalty = repetitionPenalty;
            this.Stop = stop;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FIMCompletionRequest" /> class.
        /// </summary>
        public FIMCompletionRequest()
        {
        }

    }
}