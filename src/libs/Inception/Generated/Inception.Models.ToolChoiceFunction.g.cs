
#nullable enable

namespace Inception
{
    /// <summary>
    /// The `function` object of a named tool_choice.
    /// </summary>
    public sealed partial class ToolChoiceFunction
    {
        /// <summary>
        /// Name of the tool the model must call. Must match a tool in `tools`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceFunction" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool the model must call. Must match a tool in `tools`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoiceFunction(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceFunction" /> class.
        /// </summary>
        public ToolChoiceFunction()
        {
        }

    }
}