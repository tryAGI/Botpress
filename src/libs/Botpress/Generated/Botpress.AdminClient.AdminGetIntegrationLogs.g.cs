
#nullable enable

namespace Botpress
{
    public partial class AdminClient
    {
        partial void PrepareAdminGetIntegrationLogsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            ref string timeStart,
            ref string? timeEnd,
            ref string? level,
            ref string? userId,
            ref string? conversationId,
            ref string? messageContains,
            ref string? nextToken,
            ref string xWorkspaceId,
            ref string? xMultipleIntegrations);
        partial void PrepareAdminGetIntegrationLogsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            string timeStart,
            string? timeEnd,
            string? level,
            string? userId,
            string? conversationId,
            string? messageContains,
            string? nextToken,
            string xWorkspaceId,
            string? xMultipleIntegrations);
        partial void ProcessAdminGetIntegrationLogsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Get integration logs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="timeStart"></param>
        /// <param name="timeEnd"></param>
        /// <param name="level"></param>
        /// <param name="userId"></param>
        /// <param name="conversationId"></param>
        /// <param name="messageContains"></param>
        /// <param name="nextToken"></param>
        /// <param name="xWorkspaceId"></param>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AdminGetIntegrationLogsAsync(
            string id,
            string timeStart,
            string xWorkspaceId,
            string? timeEnd = default,
            string? level = default,
            string? userId = default,
            string? conversationId = default,
            string? messageContains = default,
            string? nextToken = default,
            string? xMultipleIntegrations = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAdminGetIntegrationLogsArguments(
                httpClient: HttpClient,
                id: ref id,
                timeStart: ref timeStart,
                timeEnd: ref timeEnd,
                level: ref level,
                userId: ref userId,
                conversationId: ref conversationId,
                messageContains: ref messageContains,
                nextToken: ref nextToken,
                xWorkspaceId: ref xWorkspaceId,
                xMultipleIntegrations: ref xMultipleIntegrations);

            var __pathBuilder = new global::Botpress.PathBuilder(
                path: $"/v1/admin/integrations/{id}/logs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("timeStart", timeStart)
                .AddOptionalParameter("timeEnd", timeEnd)
                .AddOptionalParameter("level", level)
                .AddOptionalParameter("userId", userId)
                .AddOptionalParameter("conversationId", conversationId)
                .AddOptionalParameter("messageContains", messageContains)
                .AddOptionalParameter("nextToken", nextToken) 
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
            PrepareAdminGetIntegrationLogsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                timeStart: timeStart,
                timeEnd: timeEnd,
                level: level,
                userId: userId,
                conversationId: conversationId,
                messageContains: messageContains,
                nextToken: nextToken,
                xWorkspaceId: xWorkspaceId,
                xMultipleIntegrations: xMultipleIntegrations);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAdminGetIntegrationLogsResponse(
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