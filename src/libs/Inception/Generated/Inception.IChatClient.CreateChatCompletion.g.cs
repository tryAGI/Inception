#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Inception
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create a chat completion<br/>
        /// Generate a chat completion from a sequence of messages. Returns a `ChatCompletion` object, or a server-sent events stream of `ChatCompletionChunk` deltas when `stream=true`. Supports tool calling, structured output via `response_format`, and reasoning controls.
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
        /// chat_completion = client.chat.completions.create(<br/>
        ///     model="mercury-2.5",<br/>
        ///     messages=[<br/>
        ///         {<br/>
        ///             "role": "user",<br/>
        ///             "content": "What is a diffusion language model?"<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     max_tokens=256,<br/>
        ///     temperature=0.75,<br/>
        /// )<br/>
        /// print(chat_completion)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Inception.ChatCompletionResponse> CreateChatCompletionAsync(

            global::Inception.ChatCompletionRequest request,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion<br/>
        /// Generate a chat completion from a sequence of messages. Returns a `ChatCompletion` object, or a server-sent events stream of `ChatCompletionChunk` deltas when `stream=true`. Supports tool calling, structured output via `response_format`, and reasoning controls.
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
        /// chat_completion = client.chat.completions.create(<br/>
        ///     model="mercury-2.5",<br/>
        ///     messages=[<br/>
        ///         {<br/>
        ///             "role": "user",<br/>
        ///             "content": "What is a diffusion language model?"<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     max_tokens=256,<br/>
        ///     temperature=0.75,<br/>
        /// )<br/>
        /// print(chat_completion)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Inception.AutoSDKHttpResponse<global::Inception.ChatCompletionResponse>> CreateChatCompletionAsResponseAsync(

            global::Inception.ChatCompletionRequest request,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion<br/>
        /// Generate a chat completion from a sequence of messages. Returns a `ChatCompletion` object, or a server-sent events stream of `ChatCompletionChunk` deltas when `stream=true`. Supports tool calling, structured output via `response_format`, and reasoning controls.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="model">
        /// The model to use for the chat completion.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// An upper bound for the number of tokens that can be generated for a completion, including visible output tokens and reasoning tokens. Supersedes `max_tokens`. When neither field is supplied, the model's configured default applies (16384 for `mercury-2`). The maximum depends on `model`: 50,000 for `mercury-2`; 65,536 for `mercury-2.5`; 131,072 for `mercury-3`. When neither token-budget field is supplied: For `mercury-2`, the default is 16,384. For `mercury-2.5`, the default is 16,384; 65,536 when `reasoning_effort="high"`. For `mercury-3`, the default is 24,576; 8,192 when `reasoning_effort="instant"`; 65,536 when `reasoning_effort="medium"`; 131,072 when `reasoning_effort="high"`.
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0.5 and 1. Higher values make the output more random; lower values make it more focused and deterministic. For `mercury-2`, the default is 0.75; out-of-range values are reset to 0.75 with a `warning` in the response. For `mercury-2.5`, the default is 1; out-of-range values are reset to 1 with a `warning` in the response. For `mercury-3`, the default is 1; out-of-range values are reset to 1 with a `warning` in the response.
        /// </param>
        /// <param name="stop">
        /// A list of sequences where the API will stop generating further tokens. The returned text will not contain the stop sequences.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Use this to provide functions the model can generate JSON arguments for.
        /// </param>
        /// <param name="toolChoice">
        /// Controls tool selection: 'auto' (model decides, default when tools present), 'required' (model must call one), 'none' (model must not call one), or {"type": "function", "function": {"name": "..."}} to force one declared tool.
        /// </param>
        /// <param name="streamOptions">
        /// Options that control streaming behavior.
        /// </param>
        /// <param name="diffusing">
        /// Whether to show the diffusion effect in the streamed response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="extraBody">
        /// Extra parameters passed to the model (OpenAI-compat passthrough).
        /// </param>
        /// <param name="realtime">
        /// Enable flag for more realtime workloads that require lower TTFT/TTFAT.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output.
        /// </param>
        /// <param name="reasoningSummary">
        /// Request a summary of the model's reasoning process.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="reasoningSummaryWait">
        /// Wait for all reasoning summaries to complete before finishing the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="reasoningEffort">
        /// Constrains the effort spent on reasoning before the model responds.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Inception.ChatCompletionResponse> CreateChatCompletionAsync(
            global::System.Collections.Generic.IList<global::Inception.Message> messages,
            string model,
            int? maxCompletionTokens = default,
            double? temperature = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            global::System.Collections.Generic.IList<global::Inception.ChatCompletionTool>? tools = default,
            global::Inception.AnyOf<global::Inception.ChatCompletionRequestToolChoice?, global::Inception.NamedToolChoice>? toolChoice = default,
            global::Inception.StreamOptions? streamOptions = default,
            bool? diffusing = default,
            object? extraBody = default,
            bool? realtime = default,
            global::Inception.OneOf<global::Inception.ResponseFormatText, global::Inception.ResponseFormatJSONObject, global::Inception.ResponseFormatJSONSchema>? responseFormat = default,
            bool? reasoningSummary = default,
            bool? reasoningSummaryWait = default,
            global::Inception.ChatCompletionRequestReasoningEffort? reasoningEffort = default,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}