#nullable enable

namespace Inception
{
    public partial interface IEditClient
    {
        /// <summary>
        /// Create a code edit completion<br/>
        /// Generate an edit to a code region given the surrounding context. The request must contain a single user message whose content includes the required edit prompt tags (e.g. `&lt;|code_to_edit|&gt;`, `&lt;|cursor|&gt;`, `&lt;|current_file_content|&gt;`). Returns an `EditCompletion` object. Streaming and tool calling are not supported on this endpoint.
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
        /// edit_completion = client.edit.completions.create(<br/>
        ///     model="mercury-edit-2",<br/>
        ///     messages=[<br/>
        ///         {<br/>
        ///             "role": "user",<br/>
        ///             "content": "&lt;|recently_viewed_code_snippets|&gt;\n&lt;|/recently_viewed_code_snippets|&gt;\n&lt;|edit_diff_history|&gt;\n&lt;|/edit_diff_history|&gt;\n&lt;|current_file_content|&gt;\ndef greet(name):\n    print(\"hi\")\n&lt;|/current_file_content|&gt;\n&lt;|code_to_edit|&gt;\ndef greet(name):\n    print(\"hi\")&lt;|cursor|&gt;\n&lt;|/code_to_edit|&gt;"<br/>
        ///         }<br/>
        ///     ],<br/>
        /// )<br/>
        /// print(edit_completion)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Inception.EditCompletionResponse> CreateEditCompletionAsync(

            global::Inception.EditCompletionRequest request,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a code edit completion<br/>
        /// Generate an edit to a code region given the surrounding context. The request must contain a single user message whose content includes the required edit prompt tags (e.g. `&lt;|code_to_edit|&gt;`, `&lt;|cursor|&gt;`, `&lt;|current_file_content|&gt;`). Returns an `EditCompletion` object. Streaming and tool calling are not supported on this endpoint.
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
        /// edit_completion = client.edit.completions.create(<br/>
        ///     model="mercury-edit-2",<br/>
        ///     messages=[<br/>
        ///         {<br/>
        ///             "role": "user",<br/>
        ///             "content": "&lt;|recently_viewed_code_snippets|&gt;\n&lt;|/recently_viewed_code_snippets|&gt;\n&lt;|edit_diff_history|&gt;\n&lt;|/edit_diff_history|&gt;\n&lt;|current_file_content|&gt;\ndef greet(name):\n    print(\"hi\")\n&lt;|/current_file_content|&gt;\n&lt;|code_to_edit|&gt;\ndef greet(name):\n    print(\"hi\")&lt;|cursor|&gt;\n&lt;|/code_to_edit|&gt;"<br/>
        ///         }<br/>
        ///     ],<br/>
        /// )<br/>
        /// print(edit_completion)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Inception.AutoSDKHttpResponse<global::Inception.EditCompletionResponse>> CreateEditCompletionAsResponseAsync(

            global::Inception.EditCompletionRequest request,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a code edit completion<br/>
        /// Generate an edit to a code region given the surrounding context. The request must contain a single user message whose content includes the required edit prompt tags (e.g. `&lt;|code_to_edit|&gt;`, `&lt;|cursor|&gt;`, `&lt;|current_file_content|&gt;`). Returns an `EditCompletion` object. Streaming and tool calling are not supported on this endpoint.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="model">
        /// The model to use for the edit completion.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values make the output more random; lower values make it more focused and deterministic.<br/>
        /// Default Value: 0.2F
        /// </param>
        /// <param name="topP">
        /// Float that controls the cumulative probability of the top tokens to consider.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="presencePenalty">
        /// Number between -2 and 2. Positive values penalize tokens based on whether they have appeared in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Inception.EditCompletionResponse> CreateEditCompletionAsync(
            global::System.Collections.Generic.IList<global::Inception.EditMessageParam> messages,
            string model,
            int? maxTokens = default,
            double? temperature = default,
            double? topP = default,
            double? presencePenalty = default,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}