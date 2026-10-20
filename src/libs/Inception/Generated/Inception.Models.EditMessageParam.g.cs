
#nullable enable

namespace Inception
{
    /// <summary>
    /// Edit request message. Edit endpoints only accept a single user message.
    /// </summary>
    public sealed partial class EditMessageParam
    {
        /// <summary>
        /// Edit requests only accept user messages.<br/>
        /// Default Value: user
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "user";

        /// <summary>
        /// The content of the edit request. Must contain the required edit prompt tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<object>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inception.AnyOf<string, global::System.Collections.Generic.IList<object>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditMessageParam" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the edit request. Must contain the required edit prompt tags.
        /// </param>
        /// <param name="role">
        /// Edit requests only accept user messages.<br/>
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditMessageParam(
            global::Inception.AnyOf<string, global::System.Collections.Generic.IList<object>> content,
            string role = "user")
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditMessageParam" /> class.
        /// </summary>
        public EditMessageParam()
        {
        }

    }
}