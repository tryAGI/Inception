
#nullable enable

namespace Inception
{
    /// <summary>
    /// Response model for models endpoint.<br/>
    /// Example: {"data":[{"id":"mercury-2","name":"Inception: Mercury 2","created":1745798400,"description":"Mercury 2 diffusion language model for chat completions.","input_modalities":["text"],"output_modalities":["text"],"context_length":128000,"max_output_length":50000,"pricing":{"prompt":"0.00000025","completion":"0.00000075","input_cache_reads":"0.000000025","input_cache_writes":"0"},"supported_sampling_parameters":["temperature","stop"],"supported_features":["tools","json_mode","structured_outputs"],"supported_endpoints":["chat.completions"],"openrouter":{"slug":"inception/mercury-2"},"datacenters":[{"country_code":"US"}]},{"id":"mercury-2.5","name":"Inception: Mercury 2.5","created":1745798400,"description":"Mercury 2.5 diffusion language model for chat completions.","input_modalities":["text"],"output_modalities":["text"],"context_length":260000,"max_output_length":65536,"pricing":{"prompt":"0.0000002","completion":"0.00000075","input_cache_reads":"0.00000002","input_cache_writes":"0"},"supported_sampling_parameters":["temperature","stop"],"supported_features":["tools","json_mode","structured_outputs"],"supported_endpoints":["chat.completions"],"openrouter":{"slug":"inception/mercury-2.5"},"datacenters":[{"country_code":"US"}]},{"id":"mercury-3","name":"Inception: Mercury 3","created":1745798400,"description":"Mercury 3 diffusion language model for chat completions.","input_modalities":["text"],"output_modalities":["text"],"context_length":1000000,"max_output_length":131072,"pricing":{"prompt":"0","completion":"0","input_cache_reads":"0","input_cache_writes":"0"},"supported_sampling_parameters":["temperature","stop"],"supported_features":["tools","json_mode","structured_outputs"],"supported_endpoints":["chat.completions"],"openrouter":{"slug":"inception/mercury-3"},"datacenters":[{"country_code":"US"}]},{"id":"mercury-decide","name":"Inception: Mercury Decide","created":1745798400,"description":"Typed-decision preview. Decisions endpoint only.","input_modalities":["text"],"output_modalities":["text"],"context_length":65536,"max_output_length":50000,"pricing":{"prompt":"0.00000002","completion":"0","input_cache_reads":"0","input_cache_writes":"0"},"supported_sampling_parameters":["temperature","stop"],"supported_features":[],"supported_endpoints":["decisions"],"openrouter":{"slug":"inception/mercury-decide"},"datacenters":[{"country_code":"US"}]}]}
    /// </summary>
    public sealed partial class ModelsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Inception.ModelObject> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsResponse(
            global::System.Collections.Generic.IList<global::Inception.ModelObject> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsResponse" /> class.
        /// </summary>
        public ModelsResponse()
        {
        }

    }
}