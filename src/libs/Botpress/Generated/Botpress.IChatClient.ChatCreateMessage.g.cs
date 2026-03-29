#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create Message<br/>
        /// Creates a new [Message](#schema_message)
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatCreateMessageResponse> ChatCreateMessageAsync(
            string xUserKey,

            global::Botpress.ChatCreateMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Message<br/>
        /// Creates a new [Message](#schema_message)
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="payload">
        /// Payload is the content type of the message.
        /// </param>
        /// <param name="conversationId">
        /// ID of the [Conversation](#schema_conversation)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatCreateMessageResponse> ChatCreateMessageAsync(
            string xUserKey,
            global::Botpress.OneOf<global::Botpress.ChatCreateMessageRequestPayloadVariant1, global::Botpress.ChatCreateMessageRequestPayloadVariant2, global::Botpress.ChatCreateMessageRequestPayloadVariant3, global::Botpress.ChatCreateMessageRequestPayloadVariant4, global::Botpress.ChatCreateMessageRequestPayloadVariant5, global::Botpress.ChatCreateMessageRequestPayloadVariant6, global::Botpress.ChatCreateMessageRequestPayloadVariant7, global::Botpress.ChatCreateMessageRequestPayloadVariant8, global::Botpress.ChatCreateMessageRequestPayloadVariant9, global::Botpress.ChatCreateMessageRequestPayloadVariant10, global::Botpress.ChatCreateMessageRequestPayloadVariant11> payload,
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}