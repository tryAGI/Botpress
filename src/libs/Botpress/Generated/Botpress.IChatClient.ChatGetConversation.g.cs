#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Get Conversation<br/>
        /// Retrieves the [Conversation](#schema_conversation) object for a valid identifier.
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatGetConversationResponse> ChatGetConversationAsync(
            string xUserKey,
            string id,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Conversation<br/>
        /// Retrieves the [Conversation](#schema_conversation) object for a valid identifier.
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.AutoSDKHttpResponse<global::Botpress.ChatGetConversationResponse>> ChatGetConversationAsResponseAsync(
            string xUserKey,
            string id,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}