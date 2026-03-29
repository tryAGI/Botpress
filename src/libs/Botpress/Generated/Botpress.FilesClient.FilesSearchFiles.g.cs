
#nullable enable

namespace Botpress
{
    public partial class FilesClient
    {
        partial void PrepareFilesSearchFilesArguments(
            global::System.Net.Http.HttpClient httpClient,
            object? tags,
            ref string query,
            ref int? contextDepth,
            ref int? limit,
            ref bool? consolidate,
            ref bool? includeBreadcrumb,
            ref bool? withContext,
            ref string xBotId,
            ref string? xIntegrationId,
            ref string? xIntegrationAlias,
            ref string? xIntegrationName,
            ref string? xUserId,
            ref string? xUserRole);
        partial void PrepareFilesSearchFilesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            object? tags,
            string query,
            int? contextDepth,
            int? limit,
            bool? consolidate,
            bool? includeBreadcrumb,
            bool? withContext,
            string xBotId,
            string? xIntegrationId,
            string? xIntegrationAlias,
            string? xIntegrationName,
            string? xUserId,
            string? xUserRole);
        partial void ProcessFilesSearchFilesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Search files
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="query"></param>
        /// <param name="contextDepth"></param>
        /// <param name="limit"></param>
        /// <param name="consolidate"></param>
        /// <param name="includeBreadcrumb"></param>
        /// <param name="withContext"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="xIntegrationName"></param>
        /// <param name="xUserId"></param>
        /// <param name="xUserRole"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        public async global::System.Threading.Tasks.Task FilesSearchFilesAsync(
            string query,
            string xBotId,
            object? tags = default,
            int? contextDepth = default,
            int? limit = default,
            bool? consolidate = default,
            bool? includeBreadcrumb = default,
            bool? withContext = default,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            string? xIntegrationName = default,
            string? xUserId = default,
            string? xUserRole = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareFilesSearchFilesArguments(
                httpClient: HttpClient,
                tags: tags,
                query: ref query,
                contextDepth: ref contextDepth,
                limit: ref limit,
                consolidate: ref consolidate,
                includeBreadcrumb: ref includeBreadcrumb,
                withContext: ref withContext,
                xBotId: ref xBotId,
                xIntegrationId: ref xIntegrationId,
                xIntegrationAlias: ref xIntegrationAlias,
                xIntegrationName: ref xIntegrationName,
                xUserId: ref xUserId,
                xUserRole: ref xUserRole);

            var __pathBuilder = new global::Botpress.PathBuilder(
                path: "/v1/files/search",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("tags", tags?.ToString())
                .AddRequiredParameter("query", query)
                .AddOptionalParameter("contextDepth", contextDepth?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("consolidate", consolidate?.ToString().ToLowerInvariant())
                .AddOptionalParameter("includeBreadcrumb", includeBreadcrumb?.ToString().ToLowerInvariant())
                .AddOptionalParameter("withContext", withContext?.ToString().ToLowerInvariant()) 
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

            __httpRequest.Headers.TryAddWithoutValidation("x-bot-id", xBotId.ToString());
            if (xIntegrationId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-integration-id", xIntegrationId.ToString());
            }
            if (xIntegrationAlias != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-integration-alias", xIntegrationAlias.ToString());
            }
            if (xIntegrationName != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-integration-name", xIntegrationName.ToString());
            }
            if (xUserId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-user-id", xUserId.ToString());
            }
            if (xUserRole != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-user-role", xUserRole.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareFilesSearchFilesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                tags: tags,
                query: query,
                contextDepth: contextDepth,
                limit: limit,
                consolidate: consolidate,
                includeBreadcrumb: includeBreadcrumb,
                withContext: withContext,
                xBotId: xBotId,
                xIntegrationId: xIntegrationId,
                xIntegrationAlias: xIntegrationAlias,
                xIntegrationName: xIntegrationName,
                xUserId: xUserId,
                xUserRole: xUserRole);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFilesSearchFilesResponse(
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