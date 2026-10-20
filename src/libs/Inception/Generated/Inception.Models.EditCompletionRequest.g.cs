
#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EditCompletionRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Inception.EditMessageParam> Messages { get; set; }

        /// <summary>
        /// The model to use for the edit completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values make the output more random; lower values make it more focused and deterministic.<br/>
        /// Default Value: 0.2F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Float that controls the cumulative probability of the top tokens to consider.<br/>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Number between -2 and 2. Positive values penalize tokens based on whether they have appeared in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCompletionRequest" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="model">
        /// The model to use for the edit completion.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values make the output more random; lower values make it more focused and deterministic.<br/>
        /// Default Value: 0.2F
        /// </param>
        /// <param name="topP">
        /// Float that controls the cumulative probability of the top tokens to consider.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="presencePenalty">
        /// Number between -2 and 2. Positive values penalize tokens based on whether they have appeared in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 1F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditCompletionRequest(
            global::System.Collections.Generic.IList<global::Inception.EditMessageParam> messages,
            string model,
            int? maxTokens,
            double? temperature,
            double? topP,
            double? presencePenalty)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.PresencePenalty = presencePenalty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCompletionRequest" /> class.
        /// </summary>
        public EditCompletionRequest()
        {
        }

    }
}