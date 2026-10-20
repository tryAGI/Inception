
#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponseFormatJSONSchema
    {
        /// <summary>
        /// The type of response format being defined. Always `json_schema`.
        /// </summary>
        /// <default>"json_schema"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "json_schema";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inception.JSONSchema JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJSONSchema" /> class.
        /// </summary>
        /// <param name="jsonSchema"></param>
        /// <param name="type">
        /// The type of response format being defined. Always `json_schema`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFormatJSONSchema(
            global::Inception.JSONSchema jsonSchema,
            string type = "json_schema")
        {
            this.Type = type;
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJSONSchema" /> class.
        /// </summary>
        public ResponseFormatJSONSchema()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ResponseFormatJSONSchema"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ResponseFormatJSONSchema FromJsonSchema(global::Inception.JSONSchema jsonSchema)
        {
            return new ResponseFormatJSONSchema
            {
                JsonSchema = jsonSchema,
            };
        }

    }
}