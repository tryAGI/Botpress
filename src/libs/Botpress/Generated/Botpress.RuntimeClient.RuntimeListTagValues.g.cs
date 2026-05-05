
#nullable enable

namespace Botpress
{
    public partial class RuntimeClient
    {


        private static readonly global::Botpress.EndPointSecurityRequirement s_RuntimeListTagValuesSecurityRequirement0 =
            new global::Botpress.EndPointSecurityRequirement
            {
                Authorizations = new global::Botpress.EndPointAuthorizationRequirement[]
                {                    new global::Botpress.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Botpress.EndPointSecurityRequirement[] s_RuntimeListTagValuesSecurityRequirements =
            new global::Botpress.EndPointSecurityRequirement[]
            {                s_RuntimeListTagValuesSecurityRequirement0,
            };
        partial void PrepareRuntimeListTagValuesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? nextToken,
            ref string key,
            ref global::Botpress.RuntimeListTagValuesType type,
            ref string xBotId,
            ref string? xIntegrationId,
            ref string? xIntegrationAlias);
        partial void PrepareRuntimeListTagValuesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? nextToken,
            string key,
            global::Botpress.RuntimeListTagValuesType type,
            string xBotId,
            string? xIntegrationId,
            string? xIntegrationAlias);
        partial void ProcessRuntimeListTagValuesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Get a bot tag values
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        public async global::System.Threading.Tasks.Task RuntimeListTagValuesAsync(
            string key,
            global::Botpress.RuntimeListTagValuesType type,
            string xBotId,
            string? nextToken = default,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            await RuntimeListTagValuesAsResponseAsync(
                key: key,
                type: type,
                xBotId: xBotId,
                nextToken: nextToken,
                xIntegrationId: xIntegrationId,
                xIntegrationAlias: xIntegrationAlias,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a bot tag values
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Botpress.AutoSDKHttpResponse> RuntimeListTagValuesAsResponseAsync(
            string key,
            global::Botpress.RuntimeListTagValuesType type,
            string xBotId,
            string? nextToken = default,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRuntimeListTagValuesArguments(
                httpClient: HttpClient,
                nextToken: ref nextToken,
                key: ref key,
                type: ref type,
                xBotId: ref xBotId,
                xIntegrationId: ref xIntegrationId,
                xIntegrationAlias: ref xIntegrationAlias);


            var __authorizations = global::Botpress.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RuntimeListTagValuesSecurityRequirements,
                operationName: "RuntimeListTagValuesAsync");

            using var __timeoutCancellationTokenSource = global::Botpress.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Botpress.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Botpress.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Botpress.PathBuilder(
                                path: $"/v1/chat/tags/{key}/values",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("nextToken", nextToken)
                                .AddRequiredParameter("type", type.ToValueString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Botpress.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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

                __httpRequest.Headers.TryAddWithoutValidation("x-bot-id", xBotId.ToString());
            if (xIntegrationId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-integration-id", xIntegrationId.ToString());
            }
            if (xIntegrationAlias != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-integration-alias", xIntegrationAlias.ToString());
            }

                global::Botpress.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareRuntimeListTagValuesRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    nextToken: nextToken,
                    key: key!,
                    type: type!,
                    xBotId: xBotId!,
                    xIntegrationId: xIntegrationId,
                    xIntegrationAlias: xIntegrationAlias);

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
                    await global::Botpress.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Botpress.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RuntimeListTagValues",
                                methodName: "RuntimeListTagValuesAsync",
                                pathTemplate: "$\"/v1/chat/tags/{key}/values\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                        var __retryDelay = global::Botpress.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Botpress.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Botpress.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RuntimeListTagValues",
                                methodName: "RuntimeListTagValuesAsync",
                                pathTemplate: "$\"/v1/chat/tags/{key}/values\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                        await global::Botpress.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Botpress.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Botpress.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Botpress.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Botpress.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RuntimeListTagValues",
                                methodName: "RuntimeListTagValuesAsync",
                                pathTemplate: "$\"/v1/chat/tags/{key}/values\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                        await global::Botpress.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
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
                ProcessRuntimeListTagValuesResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Botpress.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Botpress.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RuntimeListTagValues",
                                methodName: "RuntimeListTagValuesAsync",
                                pathTemplate: "$\"/v1/chat/tags/{key}/values\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                    await global::Botpress.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Botpress.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RuntimeListTagValues",
                                methodName: "RuntimeListTagValuesAsync",
                                pathTemplate: "$\"/v1/chat/tags/{key}/values\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                            // 
                            if (!__response.IsSuccessStatusCode)
                            {
                                string? __content_default = null;
                                global::System.Exception? __exception_default = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_default = __ex;
                                }

                                throw new global::Botpress.ApiException(
                                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_default,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_default,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
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

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                return new global::Botpress.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::Botpress.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Botpress.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    return new global::Botpress.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::Botpress.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
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

                                    throw new global::Botpress.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}