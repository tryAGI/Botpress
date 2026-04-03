
#nullable enable

namespace Botpress
{
    public partial class AdminClient
    {
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
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAdminListIntegrationsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::System.Exception? __exception_default = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
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

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
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
                            cancellationToken
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
}