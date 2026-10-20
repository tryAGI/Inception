
#nullable enable

namespace Inception
{
    /// <summary>
    /// Edit response message. The model always responds as the assistant.
    /// </summary>
    public sealed partial class EditMessage
    {
        /// <summary>
        /// Edit responses are always from the assistant.<br/>
        /// Default Value: assistant
        /// </summary>
        /// <default>"assistant"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "assistant";

        /// <summary>
        /// The model's edit output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<object>>))]
        public global::Inception.AnyOf<string, global::System.Collections.Generic.IList<object>>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The model's edit output.
        /// </param>
        /// <param name="role">
        /// Edit responses are always from the assistant.<br/>
        /// Default Value: assistant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditMessage(
            global::Inception.AnyOf<string, global::System.Collections.Generic.IList<object>>? content,
            string role = "assistant")
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditMessage" /> class.
        /// </summary>
        public EditMessage()
        {
        }

    }
}