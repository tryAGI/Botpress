#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create Event<br/>
        /// Creates a custom [Event](#schema_event)
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatCreateEventResponse> ChatCreateEventAsync(
            string xUserKey,

            global::Botpress.ChatCreateEventRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Event<br/>
        /// Creates a custom [Event](#schema_event)
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="payload">
        /// Payload is the content of the custom event.
        /// </param>
        /// <param name="conversationId">
        /// ID of the [Conversation](#schema_conversation)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatCreateEventResponse> ChatCreateEventAsync(
            string xUserKey,
            object payload,
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}