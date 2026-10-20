
#nullable enable

namespace Inception
{
    /// <summary>
    /// Options for controlling streaming behavior. Only used when `stream=true`.
    /// </summary>
    public sealed partial class StreamOptions
    {
        /// <summary>
        /// If true, an additional chunk is streamed before the `data: [DONE]` message containing the token usage statistics for the entire request. Inside that chunk, `choices` is an empty array and the `usage` field is populated.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_usage")]
        public bool? IncludeUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamOptions" /> class.
        /// </summary>
        /// <param name="includeUsage">
        /// If true, an additional chunk is streamed before the `data: [DONE]` message containing the token usage statistics for the entire request. Inside that chunk, `choices` is an empty array and the `usage` field is populated.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamOptions(
            bool? includeUsage)
        {
            this.IncludeUsage = includeUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamOptions" /> class.
        /// </summary>
        public StreamOptions()
        {
        }

    }
}