
#nullable enable

namespace Botpress
{
    public partial class AdminClient
    {
        partial void PrepareAdminListBotsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? dev,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            ref string? nextToken,
            ref global::Botpress.AdminListBotsSortField? sortField,
            ref global::Botpress.AdminListBotsSortDirection? sortDirection,
            ref string xWorkspaceId,
            ref string? xMultipleIntegrations);
        partial void PrepareAdminListBotsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? dev,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            string? nextToken,
            global::Botpress.AdminListBotsSortField? sortField,
            global::Botpress.AdminListBotsSortDirection? sortDirection,
            string xWorkspaceId,
            string? xMultipleIntegrations);
        partial void ProcessAdminListBotsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// List bots
        /// </summary>
        /// <param name="dev"></param>
        /// <param name="tags"></param>
        /// <param name="nextToken"></param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection"></param>
        /// <param name="xWorkspaceId"></param>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AdminListBotsAsync(
            string xWorkspaceId,
            bool? dev = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            string? nextToken = default,
            global::Botpress.AdminListBotsSortField? sortField = default,
            global::Botpress.AdminListBotsSortDirection? sortDirection = default,
            string? xMultipleIntegrations = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAdminListBotsArguments(
                httpClient: HttpClient,
                dev: ref dev,
                tags: tags,
                nextToken: ref nextToken,
                sortField: ref sortField,
                sortDirection: ref sortDirection,
                xWorkspaceId: ref xWorkspaceId,
                xMultipleIntegrations: ref xMultipleIntegrations);

            var __pathBuilder = new global::Botpress.PathBuilder(
                path: "/v1/admin/bots",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("dev", dev?.ToString().ToLowerInvariant())
                .AddOptionalParameter("tags", tags?.ToString())
                .AddOptionalParameter("nextToken", nextToken)
                .AddOptionalParameter("sortField", sortField?.ToValueString())
                .AddOptionalParameter("sortDirection", sortDirection?.ToValueString()) 
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
            PrepareAdminListBotsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                dev: dev,
                tags: tags,
                nextToken: nextToken,
                sortField: sortField,
                sortDirection: sortDirection,
                xWorkspaceId: xWorkspaceId,
                xMultipleIntegrations: xMultipleIntegrations);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAdminListBotsResponse(
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