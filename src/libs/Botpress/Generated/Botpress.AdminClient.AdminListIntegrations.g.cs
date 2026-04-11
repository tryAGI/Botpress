
#nullable enable

namespace Botpress
{
    public partial class AdminClient
    {


        private static readonly global::Botpress.EndPointSecurityRequirement s_AdminListIntegrationsSecurityRequirement0 =
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
        private static readonly global::Botpress.EndPointSecurityRequirement[] s_AdminListIntegrationsSecurityRequirements =
            new global::Botpress.EndPointSecurityRequirement[]
            {                s_AdminListIntegrationsSecurityRequirement0,
            };
        partial void PrepareAdminListIntegrationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? nextToken,
            ref double? limit,
            ref string? name,
            ref string? version,
            ref string? interfaceId,
            ref string? interfaceName,
            ref string? installedByBotId,
            ref global::Botpress.AdminListIntegrationsVerificationStatus? verificationStatus,
            ref string? search,
            ref global::Botpress.AdminListIntegrationsSortBy? sortBy,
            ref global::Botpress.AdminListIntegrationsDirection? direction,
            ref global::Botpress.AdminListIntegrationsVisibility? visibility,
            ref bool? dev,
            ref string xWorkspaceId,
            ref string? xMultipleIntegrations);
        partial void PrepareAdminListIntegrationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? nextToken,
            double? limit,
            string? name,
            string? version,
            string? interfaceId,
            string? interfaceName,
            string? installedByBotId,
            global::Botpress.AdminListIntegrationsVerificationStatus? verificationStatus,
            string? search,
            global::Botpress.AdminListIntegrationsSortBy? sortBy,
            global::Botpress.AdminListIntegrationsDirection? direction,
            global::Botpress.AdminListIntegrationsVisibility? visibility,
            bool? dev,
            string xWorkspaceId,
            string? xMultipleIntegrations);
        partial void ProcessAdminListIntegrationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// List integrations, supports filtering and sorting capabilities
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="limit"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="interfaceId"></param>
        /// <param name="interfaceName"></param>
        /// <param name="installedByBotId"></param>
        /// <param name="verificationStatus"></param>
        /// <param name="search"></param>
        /// <param name="sortBy"></param>
        /// <param name="direction"></param>
        /// <param name="visibility"></param>
        /// <param name="dev"></param>
        /// <param name="xWorkspaceId"></param>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AdminListIntegrationsAsync(
            string xWorkspaceId,
            string? nextToken = default,
            double? limit = default,
            string? name = default,
            string? version = default,
            string? interfaceId = default,
            string? interfaceName = default,
            string? installedByBotId = default,
            global::Botpress.AdminListIntegrationsVerificationStatus? verificationStatus = default,
            string? search = default,
            global::Botpress.AdminListIntegrationsSortBy? sortBy = default,
            global::Botpress.AdminListIntegrationsDirection? direction = default,
            global::Botpress.AdminListIntegrationsVisibility? visibility = default,
            bool? dev = default,
            string? xMultipleIntegrations = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAdminListIntegrationsArguments(
                httpClient: HttpClient,
                nextToken: ref nextToken,
                limit: ref limit,
                name: ref name,
                version: ref version,
                interfaceId: ref interfaceId,
                interfaceName: ref interfaceName,
                installedByBotId: ref installedByBotId,
                verificationStatus: ref verificationStatus,
                search: ref search,
                sortBy: ref sortBy,
                direction: ref direction,
                visibility: ref visibility,
                dev: ref dev,
                xWorkspaceId: ref xWorkspaceId,
                xMultipleIntegrations: ref xMultipleIntegrations);


            var __authorizations = global::Botpress.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AdminListIntegrationsSecurityRequirements,
                operationName: "AdminListIntegrationsAsync");

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
                                path: "/v1/admin/integrations",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("nextToken", nextToken)
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("name", name)
                                .AddOptionalParameter("version", version)
                                .AddOptionalParameter("interfaceId", interfaceId)
                                .AddOptionalParameter("interfaceName", interfaceName)
                                .AddOptionalParameter("installedByBotId", installedByBotId)
                                .AddOptionalParameter("verificationStatus", verificationStatus?.ToValueString())
                                .AddOptionalParameter("search", search)
                                .AddOptionalParameter("sortBy", sortBy?.ToValueString())
                                .AddOptionalParameter("direction", direction?.ToValueString())
                                .AddOptionalParameter("visibility", visibility?.ToValueString())
                                .AddOptionalParameter("dev", dev?.ToString().ToLowerInvariant()) 
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

                __httpRequest.Headers.TryAddWithoutValidation("x-workspace-id", xWorkspaceId.ToString());
            if (xMultipleIntegrations != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-multiple-integrations", xMultipleIntegrations.ToString());
            }

                global::Botpress.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareAdminListIntegrationsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    nextToken: nextToken,
                    limit: limit,
                    name: name,
                    version: version,
                    interfaceId: interfaceId,
                    interfaceName: interfaceName,
                    installedByBotId: installedByBotId,
                    verificationStatus: verificationStatus,
                    search: search,
                    sortBy: sortBy,
                    direction: direction,
                    visibility: visibility,
                    dev: dev,
                    xWorkspaceId: xWorkspaceId,
                    xMultipleIntegrations: xMultipleIntegrations);

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
                                operationId: "AdminListIntegrations",
                                methodName: "AdminListIntegrationsAsync",
                                pathTemplate: "\"/v1/admin/integrations\"",
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Botpress.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Botpress.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AdminListIntegrations",
                                methodName: "AdminListIntegrationsAsync",
                                pathTemplate: "\"/v1/admin/integrations\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Botpress.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Botpress.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Botpress.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Botpress.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AdminListIntegrations",
                                methodName: "AdminListIntegrationsAsync",
                                pathTemplate: "\"/v1/admin/integrations\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Botpress.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessAdminListIntegrationsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Botpress.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Botpress.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AdminListIntegrations",
                                methodName: "AdminListIntegrationsAsync",
                                pathTemplate: "\"/v1/admin/integrations\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Botpress.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Botpress.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AdminListIntegrations",
                                methodName: "AdminListIntegrationsAsync",
                                pathTemplate: "\"/v1/admin/integrations\"",
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