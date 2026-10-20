
#nullable enable

namespace Inception
{
    /// <summary>
    /// Model information object.
    /// </summary>
    public sealed partial class ModelObject
    {
        /// <summary>
        /// Unique identifier for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Unix timestamp when model was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inception.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// Supported input modalities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> InputModalities { get; set; }

        /// <summary>
        /// Supported output modalities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OutputModalities { get; set; }

        /// <summary>
        /// Maximum context length in tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContextLength { get; set; }

        /// <summary>
        /// Maximum output length in tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxOutputLength { get; set; }

        /// <summary>
        /// Pricing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inception.PricingInfo Pricing { get; set; }

        /// <summary>
        /// Supported sampling parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_sampling_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SupportedSamplingParameters { get; set; }

        /// <summary>
        /// Supported model features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_features")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SupportedFeatures { get; set; }

        /// <summary>
        /// API endpoints this model can be called on, e.g. `chat.completions` or `decisions`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SupportedEndpoints { get; set; }

        /// <summary>
        /// Model description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// OpenRouter-specific metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openrouter")]
        public global::Inception.OpenRouterInfo? Openrouter { get; set; }

        /// <summary>
        /// Available datacenters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datacenters")]
        public global::System.Collections.Generic.IList<global::Inception.DataCenter>? Datacenters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelObject" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the model.
        /// </param>
        /// <param name="name">
        /// Display name for the model.
        /// </param>
        /// <param name="created">
        /// Unix timestamp when model was created.
        /// </param>
        /// <param name="inputModalities">
        /// Supported input modalities.
        /// </param>
        /// <param name="outputModalities">
        /// Supported output modalities.
        /// </param>
        /// <param name="contextLength">
        /// Maximum context length in tokens.
        /// </param>
        /// <param name="maxOutputLength">
        /// Maximum output length in tokens.
        /// </param>
        /// <param name="pricing">
        /// Pricing information.
        /// </param>
        /// <param name="supportedSamplingParameters">
        /// Supported sampling parameters.
        /// </param>
        /// <param name="supportedFeatures">
        /// Supported model features.
        /// </param>
        /// <param name="supportedEndpoints">
        /// API endpoints this model can be called on, e.g. `chat.completions` or `decisions`.
        /// </param>
        /// <param name="description">
        /// Model description.
        /// </param>
        /// <param name="openrouter">
        /// OpenRouter-specific metadata.
        /// </param>
        /// <param name="datacenters">
        /// Available datacenters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelObject(
            string id,
            string name,
            global::System.DateTimeOffset created,
            global::System.Collections.Generic.IList<string> inputModalities,
            global::System.Collections.Generic.IList<string> outputModalities,
            int contextLength,
            int maxOutputLength,
            global::Inception.PricingInfo pricing,
            global::System.Collections.Generic.IList<string> supportedSamplingParameters,
            global::System.Collections.Generic.IList<string> supportedFeatures,
            global::System.Collections.Generic.IList<string> supportedEndpoints,
            string? description,
            global::Inception.OpenRouterInfo? openrouter,
            global::System.Collections.Generic.IList<global::Inception.DataCenter>? datacenters)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Created = created;
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
            this.ContextLength = contextLength;
            this.MaxOutputLength = maxOutputLength;
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.SupportedSamplingParameters = supportedSamplingParameters ?? throw new global::System.ArgumentNullException(nameof(supportedSamplingParameters));
            this.SupportedFeatures = supportedFeatures ?? throw new global::System.ArgumentNullException(nameof(supportedFeatures));
            this.SupportedEndpoints = supportedEndpoints ?? throw new global::System.ArgumentNullException(nameof(supportedEndpoints));
            this.Description = description;
            this.Openrouter = openrouter;
            this.Datacenters = datacenters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelObject" /> class.
        /// </summary>
        public ModelObject()
        {
        }

    }
}