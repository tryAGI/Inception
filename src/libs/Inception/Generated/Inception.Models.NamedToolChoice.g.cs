
#nullable enable

namespace Inception
{
    /// <summary>
    /// Forces one declared tool: {"type": "function", "function": {"name": "..."}}.
    /// </summary>
    public sealed partial class NamedToolChoice
    {
        /// <summary>
        /// Always `function`.
        /// </summary>
        /// <default>"function"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "function";

        /// <summary>
        /// The `function` object of a named tool_choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inception.ToolChoiceFunction Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedToolChoice" /> class.
        /// </summary>
        /// <param name="function">
        /// The `function` object of a named tool_choice.
        /// </param>
        /// <param name="type">
        /// Always `function`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamedToolChoice(
            global::Inception.ToolChoiceFunction function,
            string type = "function")
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedToolChoice" /> class.
        /// </summary>
        public NamedToolChoice()
        {
        }

        /// <summary>
        /// Creates a new <see cref="NamedToolChoice"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static NamedToolChoice FromFunction(global::Inception.ToolChoiceFunction function)
        {
            return new NamedToolChoice
            {
                Function = function,
            };
        }

    }
}