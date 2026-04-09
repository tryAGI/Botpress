
#nullable enable

namespace Botpress
{
    public partial class RuntimeClient
    {


        private static readonly global::Botpress.EndPointSecurityRequirement s_RuntimeListParticipantsSecurityRequirement0 =
            new global::Botpress.EndPointSecurityRequirement
            {
                Authorizations = new global::Botpress.EndPointAuthorizationRequirement[]
                {                    new global::Botpress.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Botpress.EndPointSecurityRequirement[] s_RuntimeListParticipantsSecurityRequirements =
            new global::Botpress.EndPointSecurityRequirement[]
            {                s_RuntimeListParticipantsSecurityRequirement0,
            };
        partial void PrepareRuntimeListParticipantsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? nextToken,
            ref string id,
            ref string xBotId,
            ref string? xIntegrationId,
            ref string? xIntegrationAlias);
        partial void PrepareRuntimeListParticipantsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? nextToken,
            string id,
            string xBotId,
            string? xIntegrationId,
            string? xIntegrationAlias);
        partial void ProcessRuntimeListParticipantsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Retrieves a list of [Participant](#schema_participant) for a given [Conversation](#schema_conversation).
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="id"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        public async global::System.Threading.Tasks.Task RuntimeListParticipantsAsync(
            string id,
            string xBotId,
            string? nextToken = default,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRuntimeListParticipantsArguments(
                httpClient: HttpClient,
                nextToken: ref nextToken,
                id: ref id,
                xBotId: ref xBotId,
                xIntegrationId: ref xIntegrationId,
                xIntegrationAlias: ref xIntegrationAlias);


            var __authorizations = global::Botpress.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RuntimeListParticipantsSecurityRequirements,
                operationName: "RuntimeListParticipantsAsync");

            var __pathBuilder = new global::Botpress.PathBuilder(
                path: $"/v1/chat/conversations/{id}/participants",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
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

            foreach (var __authorization in __authorizations)
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
            PrepareRuntimeListParticipantsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                nextToken: nextToken,
                id: id,
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
            ProcessRuntimeListParticipantsResponse(
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