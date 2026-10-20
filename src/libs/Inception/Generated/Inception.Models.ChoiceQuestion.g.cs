
#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChoiceQuestion
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"choice"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "choice";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>))]
        public global::Inception.AnyOf<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>? Instructions { get; set; }

        /// <summary>
        /// Required mapping of 1 to 255 option labels to descriptions. Descriptions may be null, but criteria must not be omitted, null, or empty. Options are never inferred from instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Criteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceQuestion" /> class.
        /// </summary>
        /// <param name="criteria">
        /// Required mapping of 1 to 255 option labels to descriptions. Descriptions may be null, but criteria must not be omitted, null, or empty. Options are never inferred from instructions.
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChoiceQuestion(
            object criteria,
            global::Inception.AnyOf<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>? instructions,
            string type = "choice")
        {
            this.Type = type;
            this.Instructions = instructions;
            this.Criteria = criteria ?? throw new global::System.ArgumentNullException(nameof(criteria));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceQuestion" /> class.
        /// </summary>
        public ChoiceQuestion()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChoiceQuestion"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChoiceQuestion FromCriteria(object criteria)
        {
            return new ChoiceQuestion
            {
                Criteria = criteria,
            };
        }

    }
}