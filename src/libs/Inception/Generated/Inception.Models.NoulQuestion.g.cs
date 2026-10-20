
#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NoulQuestion
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"noul"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "noul";

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
        public global::Inception.NoulCriteria? Criteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NoulQuestion" /> class.
        /// </summary>
        /// <param name="instructions"></param>
        /// <param name="criteria"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NoulQuestion(
            global::Inception.AnyOf<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>? instructions,
            global::Inception.NoulCriteria? criteria,
            string type = "noul")
        {
            this.Type = type;
            this.Instructions = instructions;
            this.Criteria = criteria;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoulQuestion" /> class.
        /// </summary>
        public NoulQuestion()
        {
        }

    }
}