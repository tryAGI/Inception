
#nullable enable

namespace Inception
{
    /// <summary>
    /// Example: {"id":"cmpl-7a2b3c4d5e","object":"edit.completion","created":1745798400,"model":"mercury-edit-2","choices":[{"index":0,"finish_reason":"stop","message":{"role":"assistant","content":"def greet(name):\n    print(f\u0022hi {name}\u0022)\n"}}],"usage":{"prompt_tokens":156,"completion_tokens":18,"total_tokens":174,"reasoning_tokens":0,"cached_input_tokens":0}}
    /// </summary>
    public sealed partial class EditCompletionResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: edit.completion
        /// </summary>
        /// <default>"edit.completion"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "edit.completion";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Inception.EditChoice> Choices { get; set; }

        /// <summary>
        /// Usage for edit completions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inception.EditUsage Usage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning")]
        public string? Warning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCompletionResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="created"></param>
        /// <param name="model"></param>
        /// <param name="choices"></param>
        /// <param name="usage">
        /// Usage for edit completions.
        /// </param>
        /// <param name="warning"></param>
        /// <param name="object">
        /// Default Value: edit.completion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditCompletionResponse(
            string id,
            int created,
            string model,
            global::System.Collections.Generic.IList<global::Inception.EditChoice> choices,
            global::Inception.EditUsage usage,
            string? warning,
            string @object = "edit.completion")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Created = created;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Warning = warning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCompletionResponse" /> class.
        /// </summary>
        public EditCompletionResponse()
        {
        }

    }
}