
#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NoulAnswer
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
        [global::System.Text.Json.Serialization.JsonPropertyName("noul")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Noul { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NoulAnswer" /> class.
        /// </summary>
        /// <param name="noul"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NoulAnswer(
            double noul,
            string type = "noul")
        {
            this.Type = type;
            this.Noul = noul;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoulAnswer" /> class.
        /// </summary>
        public NoulAnswer()
        {
        }

        /// <summary>
        /// Creates a new <see cref="NoulAnswer"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static NoulAnswer FromNoul(double noul)
        {
            return new NoulAnswer
            {
                Noul = noul,
            };
        }

    }
}