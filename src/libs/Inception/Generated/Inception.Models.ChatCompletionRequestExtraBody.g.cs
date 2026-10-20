
#nullable enable

namespace Inception
{
    /// <summary>
    /// Extra parameters passed to the model (OpenAI-compat passthrough).
    /// </summary>
    public sealed partial class ChatCompletionRequestExtraBody
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}