
#nullable enable

namespace Inception
{
    public partial class FimClient
    {


        private static readonly global::Inception.EndPointSecurityRequirement s_CreateFimCompletionAsStreamSecurityRequirement0 =
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
        private static readonly global::Inception.EndPointSecurityRequirement[] s_CreateFimCompletionAsStreamSecurityRequirements =
            new global::Inception.EndPointSecurityRequirement[]
            {                s_CreateFimCompletionAsStreamSecurityRequirement0,
            };
        partial void PrepareCreateFimCompletionAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Inception.FIMCompletionRequest request);
        partial void PrepareCreateFimCompletionAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Inception.FIMCompletionRequest request);
        partial void ProcessCreateFimCompletionAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Inception.TextCompletionChunk> CreateFimCompletionAsStreamAsync(

            global::Inception.FIMCompletionRequest request,
            global::Inception.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::Inception.FIMCompletionRequest
            {
                Prompt = request.Prompt,
                Suffix = request.Suffix,
                Model = request.Model,
                MaxTokens = request.MaxTokens,
                TopP = request.TopP,
                TopK = request.TopK,
                FrequencyPenalty = request.FrequencyPenalty,
                PresencePenalty = request.PresencePenalty,
                RepetitionPenalty = request.RepetitionPenalty,
                Stop = request.Stop,
                Stream = true,
                StreamOptions = request.StreamOptions,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateFimCompletionAsStreamArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Inception.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateFimCompletionAsStreamSecurityRequirements,
                operationName: "CreateFimCompletionAsStreamAsync");

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
                                path: "/v1/fim/completions",
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
                    "text/event-stream");

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
                PrepareCreateFimCompletionAsStreamRequest(
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
                                operationId: "CreateFimCompletionAsStream",
                                methodName: "CreateFimCompletionAsStreamAsync",
                                pathTemplate: "\"/v1/fim/completions\"",
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
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
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
                                operationId: "CreateFimCompletionAsStream",
                                methodName: "CreateFimCompletionAsStreamAsync",
                                pathTemplate: "\"/v1/fim/completions\"",
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
                                operationId: "CreateFimCompletionAsStream",
                                methodName: "CreateFimCompletionAsStreamAsync",
                                pathTemplate: "\"/v1/fim/completions\"",
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
                ProcessCreateFimCompletionAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Inception.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Inception.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateFimCompletionAsStream",
                                methodName: "CreateFimCompletionAsStreamAsync",
                                pathTemplate: "\"/v1/fim/completions\"",
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
                                operationId: "CreateFimCompletionAsStream",
                                methodName: "CreateFimCompletionAsStreamAsync",
                                pathTemplate: "\"/v1/fim/completions\"",
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

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
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

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = global::Inception.TextCompletionChunk.FromJson(__content, JsonSerializerContext) ??
                                                       throw global::Inception.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Inception.TextCompletionChunk> CreateFimCompletionAsStreamAsync(
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
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Inception.FIMCompletionRequest
            {
                Prompt = prompt,
                Suffix = suffix,
                Model = model,
                MaxTokens = maxTokens,
                TopP = topP,
                TopK = topK,
                FrequencyPenalty = frequencyPenalty,
                PresencePenalty = presencePenalty,
                RepetitionPenalty = repetitionPenalty,
                Stop = stop,
                Stream = true,
                StreamOptions = streamOptions,
            };

            var __enumerable = CreateFimCompletionAsStreamAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}