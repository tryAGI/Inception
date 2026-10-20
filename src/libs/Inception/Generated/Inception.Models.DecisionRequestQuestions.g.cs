
#nullable enable

namespace Inception
{
    /// <summary>
    /// Example: {"billing":{"type":"noul","instructions":"Is this request about billing?"},"team":{"type":"choice","criteria":{"billing":"Payments, charges, and refunds","support":"Technical support and other requests"}},"urgency":{"type":"score","instructions":"How urgent is this request?","criteria":["Can wait","Needs attention soon","Needs immediate attention"]}}
    /// </summary>
    public sealed partial class DecisionRequestQuestions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}