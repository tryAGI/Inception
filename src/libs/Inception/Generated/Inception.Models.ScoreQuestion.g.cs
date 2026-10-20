
#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScoreQuestion
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
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>))]
        public global::Inception.AnyOf<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Inception.AnyOf<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>> Criteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreQuestion" /> class.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="instructions"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreQuestion(
            global::System.Collections.Generic.IList<global::Inception.AnyOf<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>> criteria,
            global::Inception.AnyOf<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>? instructions,
            string type = "score")
        {
            this.Type = type;
            this.Instructions = instructions;
            this.Criteria = criteria ?? throw new global::System.ArgumentNullException(nameof(criteria));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreQuestion" /> class.
        /// </summary>
        public ScoreQuestion()
        {
        }

    }
}