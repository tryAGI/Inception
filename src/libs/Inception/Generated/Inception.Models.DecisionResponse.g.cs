
#nullable enable

namespace Inception
{
    /// <summary>
    /// Example: {"model":"mercury-decide","answers":{"billing":{"type":"noul","noul":0.97},"team":{"type":"choice","choice":"billing","probabilities":{"billing":0.96,"support":0.04},"confidence":0.96},"urgency":{"type":"score","score":1.1,"legend":{"0":"Can wait","1":"Needs attention soon","2":"Needs immediate attention"},"probabilities":{"0":0.1,"1":0.7,"2":0.2},"confidence":0.7}},"usage":{"input_tokens":120,"output_tokens":3}}
    /// </summary>
    public sealed partial class DecisionResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Inception.DecisionAnswer> Answers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inception.DecisionUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionResponse" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="answers"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionResponse(
            string model,
            global::System.Collections.Generic.Dictionary<string, global::Inception.DecisionAnswer> answers,
            global::Inception.DecisionUsage usage)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Answers = answers ?? throw new global::System.ArgumentNullException(nameof(answers));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionResponse" /> class.
        /// </summary>
        public DecisionResponse()
        {
        }

    }
}