
#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FunctionDefinition
    {
        /// <summary>
        /// The name of the function to call. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of what the function does, used by the model to choose when and how to call the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The parameters the function accepts, described as a JSON Schema object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Whether to enforce strict schema adherence when generating the function call. When true, the model output is constrained to match the `parameters` schema exactly.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDefinition" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function to call. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.
        /// </param>
        /// <param name="description">
        /// A description of what the function does, used by the model to choose when and how to call the function.
        /// </param>
        /// <param name="parameters">
        /// The parameters the function accepts, described as a JSON Schema object.
        /// </param>
        /// <param name="strict">
        /// Whether to enforce strict schema adherence when generating the function call. When true, the model output is constrained to match the `parameters` schema exactly.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDefinition(
            string name,
            string? description,
            object? parameters,
            bool? strict)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDefinition" /> class.
        /// </summary>
        public FunctionDefinition()
        {
        }

    }
}