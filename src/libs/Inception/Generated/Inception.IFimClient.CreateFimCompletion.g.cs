#nullable enable

namespace Inception
{
    public partial interface IFimClient
    {
        /// <summary>
        /// Create a fill-in-the-middle completion<br/>
        /// Generate a code completion given a `prompt` (prefix) and optional `suffix`. Designed for IDE-style inline completion. Returns a `FimCompletion` object, or a server-sent events stream of `FimCompletionChunk` deltas when `stream=true`. Tool calling and function calling are not supported.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inception.ApiException"></exception>
        /// <remarks>
        /// import os<br/>
        /// from inceptionai import Inception<br/>
        /// client = Inception(<br/>
        ///     api_key=os.environ.get("INCEPTION_API_KEY"),  # defaults to this env var; can be omitted<br/>
        /// )<br/>
        /// fim_completion = client.fim.completions.create(<br/>
        ///     model="mercury-edit-2",<br/>
        ///     prompt="def fibonacci(n: int) -&gt; int:\n    if n &lt;= 1:\n        return n\n    return ",<br/>
        ///     suffix="\n\nprint(fibonacci(10))\n",<br/>
        ///     max_tokens=256,<br/>
        /// )<br/>
        /// print(fim_completion)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Inception.FIMCompletionResponse> CreateFimCompletionAsync(

            global::Inception.FIMCompletionRequest request,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a fill-in-the-middle completion<br/>
        /// Generate a code completion given a `prompt` (prefix) and optional `suffix`. Designed for IDE-style inline completion. Returns a `FimCompletion` object, or a server-sent events stream of `FimCompletionChunk` deltas when `stream=true`. Tool calling and function calling are not supported.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inception.ApiException"></exception>
        /// <remarks>
        /// import os<br/>
        /// from inceptionai import Inception<br/>
        /// client = Inception(<br/>
        ///     api_key=os.environ.get("INCEPTION_API_KEY"),  # defaults to this env var; can be omitted<br/>
        /// )<br/>
        /// fim_completion = client.fim.completions.create(<br/>
        ///     model="mercury-edit-2",<br/>
        ///     prompt="def fibonacci(n: int) -&gt; int:\n    if n &lt;= 1:\n        return n\n    return ",<br/>
        ///     suffix="\n\nprint(fibonacci(10))\n",<br/>
        ///     max_tokens=256,<br/>
        /// )<br/>
        /// print(fim_completion)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Inception.AutoSDKHttpResponse<global::Inception.FIMCompletionResponse>> CreateFimCompletionAsResponseAsync(

            global::Inception.FIMCompletionRequest request,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a fill-in-the-middle completion<br/>
        /// Generate a code completion given a `prompt` (prefix) and optional `suffix`. Designed for IDE-style inline completion. Returns a `FimCompletion` object, or a server-sent events stream of `FimCompletionChunk` deltas when `stream=true`. Tool calling and function calling are not supported.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to complete.
        /// </param>
        /// <param name="suffix">
        /// The suffix to complete.
        /// </param>
        /// <param name="model">
        /// The model to use for the FIM completion.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="topP">
        /// Float that controls the cumulative probability of the top tokens to consider.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="topK">
        /// Limits sampling to the `k` most likely tokens. Must be `-1` (disables the cutoff and considers all tokens) or an integer from 1 to 1000; other values such as 0 are rejected.<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="frequencyPenalty">
        /// Number between -2 and 2. Positive values penalize tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="presencePenalty">
        /// Number between -2 and 2. Positive values penalize tokens based on whether they have appeared in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 1.5F
        /// </param>
        /// <param name="repetitionPenalty">
        /// Penalizes tokens that have already appeared in the generated text. Must be greater than 0. Values greater than 1.0 discourage repetition; 1.0 applies no penalty.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="stop">
        /// A list of sequences where the API will stop generating further tokens. The returned text will not contain the stop sequences. Defaults to common code-block boundaries.<br/>
        /// Default Value: [, ]
        /// </param>
        /// <param name="streamOptions">
        /// Options that control streaming behavior.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Inception.FIMCompletionResponse> CreateFimCompletionAsync(
            string prompt,
            string model,
            string? suffix = default,
            int? maxTokens = default,
            double? topP = default,
            int? topK = default,
            double? frequencyPenalty = default,
            double? presencePenalty = default,
            double? repetitionPenalty = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            global::Inception.StreamOptions? streamOptions = default,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}