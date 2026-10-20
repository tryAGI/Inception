#nullable enable

namespace Inception
{
    public partial interface IDecisionsClient
    {
        /// <summary>
        /// Create a decision<br/>
        /// Evaluate named questions against a shared state with Mercury Decide. Supports binary probability (`noul`), categorical choice, and ordinal score questions. Returns answers and token usage. Streaming is not supported.<br/>
        /// Images: put chat-style parts such as `{"type": "image_url", "image_url": {"url": "data:image/png;base64,..."}}` anywhere in `state` or a question's `instructions` (not in `criteria`). Images must be base64 PNG, JPEG, WebP, or GIF data URLs (remote URLs are not supported), at most 10 MiB each and 16 per upstream request. The complete JSON request, including base64 encoding, is also subject to the gateway's whole-request body limit (20 MiB by default).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inception.ApiException"></exception>
        /// <remarks>
        /// curl https://api.inceptionlabs.ai/v1/decisions -H "Authorization: Bearer $INCEPTION_API_KEY" -H "Content-Type: application/json" -d '{<br/>
        ///   "model": "mercury-decide",<br/>
        ///   "state": {<br/>
        ///     "message": "Please refund the duplicate charge on my account."<br/>
        ///   },<br/>
        ///   "questions": {<br/>
        ///     "billing": {<br/>
        ///       "type": "noul",<br/>
        ///       "instructions": "Is this request about billing?"<br/>
        ///     },<br/>
        ///     "team": {<br/>
        ///       "type": "choice",<br/>
        ///       "criteria": {<br/>
        ///         "billing": "Payments, charges, and refunds",<br/>
        ///         "support": "Technical support and other requests"<br/>
        ///       }<br/>
        ///     },<br/>
        ///     "urgency": {<br/>
        ///       "type": "score",<br/>
        ///       "instructions": "How urgent is this request?",<br/>
        ///       "criteria": [<br/>
        ///         "Can wait",<br/>
        ///         "Needs attention soon",<br/>
        ///         "Needs immediate attention"<br/>
        ///       ]<br/>
        ///     }<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Inception.DecisionResponse> CreateDecisionAsync(

            global::Inception.DecisionRequest request,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a decision<br/>
        /// Evaluate named questions against a shared state with Mercury Decide. Supports binary probability (`noul`), categorical choice, and ordinal score questions. Returns answers and token usage. Streaming is not supported.<br/>
        /// Images: put chat-style parts such as `{"type": "image_url", "image_url": {"url": "data:image/png;base64,..."}}` anywhere in `state` or a question's `instructions` (not in `criteria`). Images must be base64 PNG, JPEG, WebP, or GIF data URLs (remote URLs are not supported), at most 10 MiB each and 16 per upstream request. The complete JSON request, including base64 encoding, is also subject to the gateway's whole-request body limit (20 MiB by default).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inception.ApiException"></exception>
        /// <remarks>
        /// curl https://api.inceptionlabs.ai/v1/decisions -H "Authorization: Bearer $INCEPTION_API_KEY" -H "Content-Type: application/json" -d '{<br/>
        ///   "model": "mercury-decide",<br/>
        ///   "state": {<br/>
        ///     "message": "Please refund the duplicate charge on my account."<br/>
        ///   },<br/>
        ///   "questions": {<br/>
        ///     "billing": {<br/>
        ///       "type": "noul",<br/>
        ///       "instructions": "Is this request about billing?"<br/>
        ///     },<br/>
        ///     "team": {<br/>
        ///       "type": "choice",<br/>
        ///       "criteria": {<br/>
        ///         "billing": "Payments, charges, and refunds",<br/>
        ///         "support": "Technical support and other requests"<br/>
        ///       }<br/>
        ///     },<br/>
        ///     "urgency": {<br/>
        ///       "type": "score",<br/>
        ///       "instructions": "How urgent is this request?",<br/>
        ///       "criteria": [<br/>
        ///         "Can wait",<br/>
        ///         "Needs attention soon",<br/>
        ///         "Needs immediate attention"<br/>
        ///       ]<br/>
        ///     }<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Inception.AutoSDKHttpResponse<global::Inception.DecisionResponse>> CreateDecisionAsResponseAsync(

            global::Inception.DecisionRequest request,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a decision<br/>
        /// Evaluate named questions against a shared state with Mercury Decide. Supports binary probability (`noul`), categorical choice, and ordinal score questions. Returns answers and token usage. Streaming is not supported.<br/>
        /// Images: put chat-style parts such as `{"type": "image_url", "image_url": {"url": "data:image/png;base64,..."}}` anywhere in `state` or a question's `instructions` (not in `criteria`). Images must be base64 PNG, JPEG, WebP, or GIF data URLs (remote URLs are not supported), at most 10 MiB each and 16 per upstream request. The complete JSON request, including base64 encoding, is also subject to the gateway's whole-request body limit (20 MiB by default).
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Inception.DecisionResponse> CreateDecisionAsync(
            string model,
            global::Inception.AnyOf<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>> state,
            global::System.Collections.Generic.Dictionary<string, global::Inception.DecisionQuestion> questions,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}