
#nullable enable

namespace Inception
{
    /// <summary>
    /// Pricing information for a model.
    /// </summary>
    public sealed partial class PricingInfo
    {
        /// <summary>
        /// Pricing per 1 token for input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Pricing per 1 token for output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Completion { get; set; }

        /// <summary>
        /// Pricing per 1 token for cache reads.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_reads")]
        public string? InputCacheReads { get; set; }

        /// <summary>
        /// Pricing per 1 token for cache writes.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_writes")]
        public string? InputCacheWrites { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingInfo" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Pricing per 1 token for input.
        /// </param>
        /// <param name="completion">
        /// Pricing per 1 token for output.
        /// </param>
        /// <param name="inputCacheReads">
        /// Pricing per 1 token for cache reads.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="inputCacheWrites">
        /// Pricing per 1 token for cache writes.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingInfo(
            string prompt,
            string completion,
            string? inputCacheReads,
            string? inputCacheWrites)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Completion = completion ?? throw new global::System.ArgumentNullException(nameof(completion));
            this.InputCacheReads = inputCacheReads;
            this.InputCacheWrites = inputCacheWrites;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingInfo" /> class.
        /// </summary>
        public PricingInfo()
        {
        }

    }
}