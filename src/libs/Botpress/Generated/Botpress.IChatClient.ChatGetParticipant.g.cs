#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Get Participant<br/>
        /// Retrieves a [Participant](#schema_user) from a [Conversation](#schema_conversation).
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="conversationId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatGetParticipantResponse> ChatGetParticipantAsync(
            string xUserKey,
            string conversationId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}