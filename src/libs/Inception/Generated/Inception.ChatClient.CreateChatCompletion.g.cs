
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Inception
{
    public partial class ChatClient
    {


        private static readonly global::Inception.EndPointSecurityRequirement s_CreateChatCompletionSecurityRequirement0 =
            new global::Inception.EndPointSecurityRequirement
            {
                Authorizations = new global::Inception.EndPointAuthorizationRequirement[]
                {                    new global::Inception.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Inception.EndPointSecurityRequirement[] s_CreateChatCompletionSecurityRequirements =
            new global::Inception.EndPointSecurityRequirement[]
            {                s_CreateChatCompletionSecurityRequirement0,
            };
        partial void PrepareCreateChatCompletionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Inception.ChatCompletionRequest request);
        partial void PrepareCreateChatCompletionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Inception.ChatCompletionRequest request);
        partial void ProcessCreateChatCompletionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateChatCompletionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Inception.ChatCompletionResponse> CreateChatCompletionAsync(

            global::Inception.ChatCompletionRequest request,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateChatCompletionAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::Inception.AutoSDKHttpResponse<global::Inception.ChatCompletionResponse>> CreateChatCompletionAsResponseAsync(

            global::Inception.ChatCompletionRequest request,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::Inception.ChatCompletionRequest
            {
                Messages = request.Messages,
                Model = request.Model,
                MaxCompletionTokens = request.MaxCompletionTokens,
                Temperature = request.Temperature,
                Stop = request.Stop,
                Tools = request.Tools,
                ToolChoice = request.ToolChoice,
                Stream = false,
                StreamOptions = request.StreamOptions,
                Diffusing = request.Diffusing,
                ExtraBody = request.ExtraBody,
                Realtime = request.Realtime,
                ResponseFormat = request.ResponseFormat,
                ReasoningSummary = request.ReasoningSummary,
                ReasoningSummaryWait = request.ReasoningSummaryWait,
                ReasoningEffort = request.ReasoningEffort,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateChatCompletionArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Inception.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateChatCompletionSecurityRequirements,
                operationName: "CreateChatCompletionAsync");

            using var __timeoutCancellationTokenSource = global::Inception.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Inception.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Inception.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Inception.PathBuilder(
                                path: "/v1/chat/completions",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Inception.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

                __httpRequest.Headers.TryAddWithoutValidation(
                    "Accept",
                    "application/json");

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Inception.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateChatCompletionRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Inception.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Inception.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateChatCompletion",
                                methodName: "CreateChatCompletionAsync",
                                pathTemplate: "\"/v1/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Inception.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Inception.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Inception.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateChatCompletion",
                                methodName: "CreateChatCompletionAsync",
                                pathTemplate: "\"/v1/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Inception.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Inception.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Inception.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Inception.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Inception.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateChatCompletion",
                                methodName: "CreateChatCompletionAsync",
                                pathTemplate: "\"/v1/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Inception.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateChatCompletionResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Inception.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Inception.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateChatCompletion",
                                methodName: "CreateChatCompletionAsync",
                                pathTemplate: "\"/v1/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Inception.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Inception.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateChatCompletion",
                                methodName: "CreateChatCompletionAsync",
                                pathTemplate: "\"/v1/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad Request — invalid parameters.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Inception.ErrorResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Inception.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Inception.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Inception.ApiException<global::Inception.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unauthorized — missing or invalid API key.
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::Inception.ErrorResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Inception.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Inception.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Inception.ApiException<global::Inception.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Payment Required — billing inactive or quota exceeded.
                            if ((int)__response.StatusCode == 402)
                            {
                                string? __content_402 = null;
                                global::System.Exception? __exception_402 = null;
                                global::Inception.ErrorResponse? __value_402 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_402 = global::Inception.ErrorResponse.FromJson(__content_402, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_402 = global::Inception.ErrorResponse.FromJson(__content_402, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_402 = __ex;
                                }


                                throw global::Inception.ApiException<global::Inception.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_402,
                                    responseBody: __content_402,
                                    responseObject: __value_402,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Not Found — model not available for this account.
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::Inception.ErrorResponse? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::Inception.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::Inception.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Inception.ApiException<global::Inception.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Too Many Requests — rate limit exceeded.
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::Inception.ErrorResponse? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::Inception.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::Inception.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::Inception.ApiException<global::Inception.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Internal Server Error.
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::Inception.ErrorResponse? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::Inception.ErrorResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::Inception.ErrorResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Inception.ApiException<global::Inception.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateChatCompletionResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Inception.ChatCompletionResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Inception.AutoSDKHttpResponse<global::Inception.ChatCompletionResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Inception.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Inception.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Inception.ChatCompletionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Inception.AutoSDKHttpResponse<global::Inception.ChatCompletionResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Inception.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Inception.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::Inception.ChatCompletionResponse> CreateChatCompletionAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Inception.ChatCompletionRequest
            {
                Messages = messages,
                Model = model,
                MaxCompletionTokens = maxCompletionTokens,
                Temperature = temperature,
                Stop = stop,
                Tools = tools,
                ToolChoice = toolChoice,
                Stream = false,
                StreamOptions = streamOptions,
                Diffusing = diffusing,
                ExtraBody = extraBody,
                Realtime = realtime,
                ResponseFormat = responseFormat,
                ReasoningSummary = reasoningSummary,
                ReasoningSummaryWait = reasoningSummaryWait,
                ReasoningEffort = reasoningEffort,
            };

            return await CreateChatCompletionAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}