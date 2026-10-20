
#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScoreAnswer
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"score"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "score";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Legend { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Probabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreAnswer" /> class.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="legend"></param>
        /// <param name="probabilities"></param>
        /// <param name="confidence"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreAnswer(
            double score,
            object legend,
            global::System.Collections.Generic.Dictionary<string, double> probabilities,
            double confidence,
            string type = "score")
        {
            this.Type = type;
            this.Score = score;
            this.Legend = legend ?? throw new global::System.ArgumentNullException(nameof(legend));
            this.Probabilities = probabilities ?? throw new global::System.ArgumentNullException(nameof(probabilities));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreAnswer" /> class.
        /// </summary>
        public ScoreAnswer()
        {
        }

    }
}