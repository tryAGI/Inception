#nullable enable

namespace Inception
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List available models<br/>
        /// List the models currently available through the API.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inception.ApiException"></exception>
        /// <remarks>
        /// import os<br/>
        /// from inceptionai import Inception<br/>
        /// client = Inception(<br/>
        ///     api_key=os.environ.get("INCEPTION_API_KEY"),  # defaults to this env var; can be omitted<br/>
        /// )<br/>
        /// models = client.models.list()<br/>
        /// print(models)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Inception.ModelsResponse> ListModelsAsync(
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List available models<br/>
        /// List the models currently available through the API.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inception.ApiException"></exception>
        /// <remarks>
        /// import os<br/>
        /// from inceptionai import Inception<br/>
        /// client = Inception(<br/>
        ///     api_key=os.environ.get("INCEPTION_API_KEY"),  # defaults to this env var; can be omitted<br/>
        /// )<br/>
        /// models = client.models.list()<br/>
        /// print(models)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Inception.AutoSDKHttpResponse<global::Inception.ModelsResponse>> ListModelsAsResponseAsync(
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}