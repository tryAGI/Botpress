
#nullable enable

namespace Botpress
{
    public partial class ChatClient
    {


        private static readonly global::Botpress.EndPointSecurityRequirement s_ChatGetOrCreateUserSecurityRequirement0 =
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
        private static readonly global::Botpress.EndPointSecurityRequirement[] s_ChatGetOrCreateUserSecurityRequirements =
            new global::Botpress.EndPointSecurityRequirement[]
            {                s_ChatGetOrCreateUserSecurityRequirement0,
            };
        partial void PrepareChatGetOrCreateUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string xUserKey,
            global::Botpress.ChatGetOrCreateUserRequest request);
        partial void PrepareChatGetOrCreateUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string xUserKey,
            global::Botpress.ChatGetOrCreateUserRequest request);
        partial void ProcessChatGetOrCreateUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChatGetOrCreateUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Or Create User<br/>
        /// Get or create a new [User](#schema_user)
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Botpress.ChatGetOrCreateUserResponse> ChatGetOrCreateUserAsync(
            string xUserKey,

            global::Botpress.ChatGetOrCreateUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareChatGetOrCreateUserArguments(
                httpClient: HttpClient,
                xUserKey: ref xUserKey,
                request: request);


            var __authorizations = global::Botpress.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ChatGetOrCreateUserSecurityRequirements,
                operationName: "ChatGetOrCreateUserAsync");

            var __pathBuilder = new global::Botpress.PathBuilder(
                path: "/chat-api/users/get-or-create",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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

            __httpRequest.Headers.TryAddWithoutValidation("x-user-key", xUserKey.ToString());

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareChatGetOrCreateUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xUserKey: xUserKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessChatGetOrCreateUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Returns a [User](#schema_user)
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::System.Exception? __exception_default = null;
                global::Botpress.ChatGetOrCreateUserResponse2? __value_default = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_default = global::Botpress.ChatGetOrCreateUserResponse2.FromJson(__content_default, JsonSerializerContext);
                    }
                    else
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_default = global::Botpress.ChatGetOrCreateUserResponse2.FromJson(__content_default, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_default = __ex;
                }

                throw new global::Botpress.ApiException<global::Botpress.ChatGetOrCreateUserResponse2>(
                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_default,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_default,
                    ResponseObject = __value_default,
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
                ProcessChatGetOrCreateUserResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Botpress.ChatGetOrCreateUserResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                    return
                        await global::Botpress.ChatGetOrCreateUserResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// <summary>
        /// Get Or Create User<br/>
        /// Get or create a new [User](#schema_user)
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="name">
        /// Name of the [User](#schema_user) (not a unique identifier)
        /// </param>
        /// <param name="pictureUrl">
        /// Picture url of the [User](#schema_user)
        /// </param>
        /// <param name="profile">
        /// Custom profile data of the [User](#schema_user) encoded as a string
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Botpress.ChatGetOrCreateUserResponse> ChatGetOrCreateUserAsync(
            string xUserKey,
            string? name = default,
            string? pictureUrl = default,
            string? profile = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Botpress.ChatGetOrCreateUserRequest
            {
                Name = name,
                PictureUrl = pictureUrl,
                Profile = profile,
            };

            return await ChatGetOrCreateUserAsync(
                xUserKey: xUserKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}