
#nullable enable

namespace Botpress
{
    public partial class RuntimeClient
    {
        partial void PrepareRuntimeListEventsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? nextToken,
            ref string? type,
            ref string? conversationId,
            ref string? userId,
            ref string? messageId,
            ref string? workflowId,
            ref global::Botpress.RuntimeListEventsStatus? status,
            ref string xBotId,
            ref string? xIntegrationId,
            ref string? xIntegrationAlias);
        partial void PrepareRuntimeListEventsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? nextToken,
            string? type,
            string? conversationId,
            string? userId,
            string? messageId,
            string? workflowId,
            global::Botpress.RuntimeListEventsStatus? status,
            string xBotId,
            string? xIntegrationId,
            string? xIntegrationAlias);
        partial void ProcessRuntimeListEventsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Retrieves a list of [Event](#schema_event) you’ve previously created. The events are returned in sorted order, with the most recent appearing first.
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="type"></param>
        /// <param name="conversationId"></param>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <param name="workflowId"></param>
        /// <param name="status"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        public async global::System.Threading.Tasks.Task RuntimeListEventsAsync(
            string xBotId,
            string? nextToken = default,
            string? type = default,
            string? conversationId = default,
            string? userId = default,
            string? messageId = default,
            string? workflowId = default,
            global::Botpress.RuntimeListEventsStatus? status = default,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRuntimeListEventsArguments(
                httpClient: HttpClient,
                nextToken: ref nextToken,
                type: ref type,
                conversationId: ref conversationId,
                userId: ref userId,
                messageId: ref messageId,
                workflowId: ref workflowId,
                status: ref status,
                xBotId: ref xBotId,
                xIntegrationId: ref xIntegrationId,
                xIntegrationAlias: ref xIntegrationAlias);

            var __pathBuilder = new global::Botpress.PathBuilder(
                path: "/v1/chat/events",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("nextToken", nextToken)
                .AddOptionalParameter("type", type)
                .AddOptionalParameter("conversationId", conversationId)
                .AddOptionalParameter("userId", userId)
                .AddOptionalParameter("messageId", messageId)
                .AddOptionalParameter("workflowId", workflowId)
                .AddOptionalParameter("status", status?.ToValueString()) 
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
            PrepareRuntimeListEventsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                nextToken: nextToken,
                type: type,
                conversationId: conversationId,
                userId: userId,
                messageId: messageId,
                workflowId: workflowId,
                status: status,
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
            ProcessRuntimeListEventsResponse(
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