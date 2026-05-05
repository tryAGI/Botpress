#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// List Conversations<br/>
        /// Returns a list of [Conversation](#schema_conversation) objects
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="nextToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatListConversationsResponse> ChatListConversationsAsync(
            string xUserKey,
            string? nextToken = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Conversations<br/>
        /// Returns a list of [Conversation](#schema_conversation) objects
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="nextToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.AutoSDKHttpResponse<global::Botpress.ChatListConversationsResponse>> ChatListConversationsAsResponseAsync(
            string xUserKey,
            string? nextToken = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}