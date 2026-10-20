
#nullable enable

namespace Inception
{
    /// <summary>
    /// Datacenter location information.
    /// </summary>
    public sealed partial class DataCenter
    {
        /// <summary>
        /// ISO 3166 Alpha-2 country code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CountryCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataCenter" /> class.
        /// </summary>
        /// <param name="countryCode">
        /// ISO 3166 Alpha-2 country code.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataCenter(
            string countryCode)
        {
            this.CountryCode = countryCode ?? throw new global::System.ArgumentNullException(nameof(countryCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataCenter" /> class.
        /// </summary>
        public DataCenter()
        {
        }

    }
}