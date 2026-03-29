#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Listen Conversation<br/>
        /// Creates a SSE stream to receive messages and events from a conversation
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatListenConversationResponse> ChatListenConversationAsync(
            string xUserKey,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}