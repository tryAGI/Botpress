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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatCreateMessageResponse> ChatCreateMessageAsync(
            string xUserKey,

            global::Botpress.ChatCreateMessageRequest request,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatCreateMessageResponse> ChatCreateMessageAsync(
            string xUserKey,
            global::Botpress.OneOf<global::Botpress.ChatCreateMessageRequestPayloadAudio, global::Botpress.ChatCreateMessageRequestPayloadCard, global::Botpress.ChatCreateMessageRequestPayloadCarousel, global::Botpress.ChatCreateMessageRequestPayloadChoice, global::Botpress.ChatCreateMessageRequestPayloadDropdown, global::Botpress.ChatCreateMessageRequestPayloadFile, global::Botpress.ChatCreateMessageRequestPayloadImage, global::Botpress.ChatCreateMessageRequestPayloadLocation, global::Botpress.ChatCreateMessageRequestPayloadMarkdown, global::Botpress.ChatCreateMessageRequestPayloadText, global::Botpress.ChatCreateMessageRequestPayloadVideo> payload,
            string conversationId,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}