#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// List Messages<br/>
        /// Retrieves the conversation's [Messages](#schema_message)
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="nextToken"></param>
        /// <param name="conversationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatListMessagesResponse> ChatListMessagesAsync(
            string xUserKey,
            string conversationId,
            string? nextToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}