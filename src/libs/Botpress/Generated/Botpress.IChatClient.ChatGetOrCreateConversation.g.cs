#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Get Or Create Conversation<br/>
        /// Get or create a new [Conversation](#schema_conversation)
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatGetOrCreateConversationResponse> ChatGetOrCreateConversationAsync(
            string xUserKey,

            global::Botpress.ChatGetOrCreateConversationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Or Create Conversation<br/>
        /// Get or create a new [Conversation](#schema_conversation)
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="id">
        /// Identifier of the [Conversation](#schema_conversation)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatGetOrCreateConversationResponse> ChatGetOrCreateConversationAsync(
            string xUserKey,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}