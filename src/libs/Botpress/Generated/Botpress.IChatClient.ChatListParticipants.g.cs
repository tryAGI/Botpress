#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// List Participants<br/>
        /// Retrieves a list of [Participants](#schema_user) for a given [Conversation](#schema_conversation).
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="nextToken"></param>
        /// <param name="conversationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatListParticipantsResponse> ChatListParticipantsAsync(
            string xUserKey,
            string conversationId,
            string? nextToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}