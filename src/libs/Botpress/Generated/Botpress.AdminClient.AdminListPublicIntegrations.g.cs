
#nullable enable

namespace Botpress
{
    public partial class AdminClient
    {
        partial void PrepareAdminListPublicIntegrationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? nextToken,
            ref double? limit,
            ref string? name,
            ref string? version,
            ref string? interfaceId,
            ref string? interfaceName,
            ref string? installedByBotId,
            ref global::Botpress.AdminListPublicIntegrationsVerificationStatus? verificationStatus,
            ref string? search,
            ref global::Botpress.AdminListPublicIntegrationsSortBy? sortBy,
            ref global::Botpress.AdminListPublicIntegrationsDirection? direction,
            ref string? xMultipleIntegrations);
        partial void PrepareAdminListPublicIntegrationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? nextToken,
            double? limit,
            string? name,
            string? version,
            string? interfaceId,
            string? interfaceName,
            string? installedByBotId,
            global::Botpress.AdminListPublicIntegrationsVerificationStatus? verificationStatus,
            string? search,
            global::Botpress.AdminListPublicIntegrationsSortBy? sortBy,
            global::Botpress.AdminListPublicIntegrationsDirection? direction,
            string? xMultipleIntegrations);
        partial void ProcessAdminListPublicIntegrationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// List public integration
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
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AdminListPublicIntegrationsAsync(
            string? nextToken = default,
            double? limit = default,
            string? name = default,
            string? version = default,
            string? interfaceId = default,
            string? interfaceName = default,
            string? installedByBotId = default,
            global::Botpress.AdminListPublicIntegrationsVerificationStatus? verificationStatus = default,
            string? search = default,
            global::Botpress.AdminListPublicIntegrationsSortBy? sortBy = default,
            global::Botpress.AdminListPublicIntegrationsDirection? direction = default,
            string? xMultipleIntegrations = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAdminListPublicIntegrationsArguments(
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
                xMultipleIntegrations: ref xMultipleIntegrations);

            var __pathBuilder = new global::Botpress.PathBuilder(
                path: "/v1/admin/hub/integrations",
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

            if (xMultipleIntegrations != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-multiple-integrations", xMultipleIntegrations.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAdminListPublicIntegrationsRequest(
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
                xMultipleIntegrations: xMultipleIntegrations);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAdminListPublicIntegrationsResponse(
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

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

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