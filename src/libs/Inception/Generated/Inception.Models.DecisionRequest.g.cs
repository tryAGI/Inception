
#nullable enable

namespace Inception
{
    /// <summary>
    /// Example: {"model":"mercury-decide","state":{"message":"Please refund the duplicate charge on my account."},"questions":{"billing":{"type":"noul","instructions":"Is this request about billing?"},"team":{"type":"choice","criteria":{"billing":"Payments, charges, and refunds","support":"Technical support and other requests"}},"urgency":{"type":"score","instructions":"How urgent is this request?","criteria":["Can wait","Needs attention soon","Needs immediate attention"]}}}
    /// </summary>
    public sealed partial class DecisionRequest
    {
        /// <summary>
        /// Example: mercury-decide
        /// </summary>
        /// <example>mercury-decide</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Example: {"message":"Please refund the duplicate charge on my account."}
        /// </summary>
        /// <example>{"message":"Please refund the duplicate charge on my account."}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inception.AnyOf<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>> State { get; set; }

        /// <summary>
        /// Example: {"billing":{"type":"noul","instructions":"Is this request about billing?"},"team":{"type":"choice","criteria":{"billing":"Payments, charges, and refunds","support":"Technical support and other requests"}},"urgency":{"type":"score","instructions":"How urgent is this request?","criteria":["Can wait","Needs attention soon","Needs immediate attention"]}}
        /// </summary>
        /// <example>{"billing":{"type":"noul","instructions":"Is this request about billing?"},"team":{"type":"choice","criteria":{"billing":"Payments, charges, and refunds","support":"Technical support and other requests"}},"urgency":{"type":"score","instructions":"How urgent is this request?","criteria":["Can wait","Needs attention soon","Needs immediate attention"]}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Inception.DecisionQuestion> Questions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Example: mercury-decide
        /// </param>
        /// <param name="state">
        /// Example: {"message":"Please refund the duplicate charge on my account."}
        /// </param>
        /// <param name="questions">
        /// Example: {"billing":{"type":"noul","instructions":"Is this request about billing?"},"team":{"type":"choice","criteria":{"billing":"Payments, charges, and refunds","support":"Technical support and other requests"}},"urgency":{"type":"score","instructions":"How urgent is this request?","criteria":["Can wait","Needs attention soon","Needs immediate attention"]}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionRequest(
            string model,
            global::Inception.AnyOf<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>> state,
            global::System.Collections.Generic.Dictionary<string, global::Inception.DecisionQuestion> questions)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.State = state;
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionRequest" /> class.
        /// </summary>
        public DecisionRequest()
        {
        }

    }
}