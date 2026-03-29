
#nullable enable

namespace Botpress
{
    public partial class RuntimeClient
    {
        partial void PrepareRuntimeListConversationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? nextToken,
            ref global::Botpress.RuntimeListConversationsSortField? sortField,
            ref global::Botpress.RuntimeListConversationsSortDirection? sortDirection,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            global::System.Collections.Generic.IList<string>? participantIds,
            ref string? integrationName,
            ref string? channel,
            ref string? afterDate,
            ref string? beforeDate,
            ref string xBotId,
            ref string? xIntegrationId,
            ref string? xIntegrationAlias);
        partial void PrepareRuntimeListConversationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? nextToken,
            global::Botpress.RuntimeListConversationsSortField? sortField,
            global::Botpress.RuntimeListConversationsSortDirection? sortDirection,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            global::System.Collections.Generic.IList<string>? participantIds,
            string? integrationName,
            string? channel,
            string? afterDate,
            string? beforeDate,
            string xBotId,
            string? xIntegrationId,
            string? xIntegrationAlias);
        partial void ProcessRuntimeListConversationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Retrieves a list of [Conversation](#schema_conversation) you’ve previously created. The conversations are returned in sorted order, with the most recent appearing first. The list can be filtered using [Tags](#tags).
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection"></param>
        /// <param name="tags"></param>
        /// <param name="participantIds"></param>
        /// <param name="integrationName"></param>
        /// <param name="channel"></param>
        /// <param name="afterDate"></param>
        /// <param name="beforeDate"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        public async global::System.Threading.Tasks.Task RuntimeListConversationsAsync(
            string xBotId,
            string? nextToken = default,
            global::Botpress.RuntimeListConversationsSortField? sortField = default,
            global::Botpress.RuntimeListConversationsSortDirection? sortDirection = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            global::System.Collections.Generic.IList<string>? participantIds = default,
            string? integrationName = default,
            string? channel = default,
            string? afterDate = default,
            string? beforeDate = default,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRuntimeListConversationsArguments(
                httpClient: HttpClient,
                nextToken: ref nextToken,
                sortField: ref sortField,
                sortDirection: ref sortDirection,
                tags: tags,
                participantIds: participantIds,
                integrationName: ref integrationName,
                channel: ref channel,
                afterDate: ref afterDate,
                beforeDate: ref beforeDate,
                xBotId: ref xBotId,
                xIntegrationId: ref xIntegrationId,
                xIntegrationAlias: ref xIntegrationAlias);

            var __pathBuilder = new global::Botpress.PathBuilder(
                path: "/v1/chat/conversations",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("nextToken", nextToken)
                .AddOptionalParameter("sortField", sortField?.ToValueString())
                .AddOptionalParameter("sortDirection", sortDirection?.ToValueString())
                .AddOptionalParameter("tags", tags?.ToString())
                .AddOptionalParameter("participantIds", participantIds, delimiter: ",", explode: true)
                .AddOptionalParameter("integrationName", integrationName)
                .AddOptionalParameter("channel", channel)
                .AddOptionalParameter("afterDate", afterDate)
                .AddOptionalParameter("beforeDate", beforeDate) 
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


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareRuntimeListConversationsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                nextToken: nextToken,
                sortField: sortField,
                sortDirection: sortDirection,
                tags: tags,
                participantIds: participantIds,
                integrationName: integrationName,
                channel: channel,
                afterDate: afterDate,
                beforeDate: beforeDate,
                xBotId: xBotId,
                xIntegrationId: xIntegrationId,
                xIntegrationAlias: xIntegrationAlias);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRuntimeListConversationsResponse(
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