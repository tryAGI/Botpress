#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create Conversation<br/>
        /// Creates a new [Conversation](#schema_conversation)
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatCreateConversationResponse> ChatCreateConversationAsync(
            string xUserKey,

            global::Botpress.ChatCreateConversationRequest request,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Conversation<br/>
        /// Creates a new [Conversation](#schema_conversation)
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="id">
        /// Identifier of the [Conversation](#schema_conversation)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatCreateConversationResponse> ChatCreateConversationAsync(
            string xUserKey,
            string? id = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}