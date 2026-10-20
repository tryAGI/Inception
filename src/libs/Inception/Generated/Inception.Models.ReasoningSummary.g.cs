
#nullable enable

namespace Inception
{
    /// <summary>
    /// Summary of the model's reasoning process.
    /// </summary>
    public sealed partial class ReasoningSummary
    {
        /// <summary>
        /// The summarized reasoning.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Status of the summary.<br/>
        /// Default Value: unavailable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inception.JsonConverters.ReasoningSummaryStatusJsonConverter))]
        public global::Inception.ReasoningSummaryStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningSummary" /> class.
        /// </summary>
        /// <param name="content">
        /// The summarized reasoning.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="status">
        /// Status of the summary.<br/>
        /// Default Value: unavailable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningSummary(
            string? content,
            global::Inception.ReasoningSummaryStatus? status)
        {
            this.Content = content;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningSummary" /> class.
        /// </summary>
        public ReasoningSummary()
        {
        }

    }
}