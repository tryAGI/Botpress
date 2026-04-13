
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCreateMessageRequest
    {
        /// <summary>
        /// Payload is the content type of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatCreateMessageRequestPayloadAudio, global::Botpress.ChatCreateMessageRequestPayloadCard, global::Botpress.ChatCreateMessageRequestPayloadCarousel, global::Botpress.ChatCreateMessageRequestPayloadChoice, global::Botpress.ChatCreateMessageRequestPayloadDropdown, global::Botpress.ChatCreateMessageRequestPayloadFile, global::Botpress.ChatCreateMessageRequestPayloadImage, global::Botpress.ChatCreateMessageRequestPayloadLocation, global::Botpress.ChatCreateMessageRequestPayloadMarkdown, global::Botpress.ChatCreateMessageRequestPayloadText, global::Botpress.ChatCreateMessageRequestPayloadVideo>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.OneOf<global::Botpress.ChatCreateMessageRequestPayloadAudio, global::Botpress.ChatCreateMessageRequestPayloadCard, global::Botpress.ChatCreateMessageRequestPayloadCarousel, global::Botpress.ChatCreateMessageRequestPayloadChoice, global::Botpress.ChatCreateMessageRequestPayloadDropdown, global::Botpress.ChatCreateMessageRequestPayloadFile, global::Botpress.ChatCreateMessageRequestPayloadImage, global::Botpress.ChatCreateMessageRequestPayloadLocation, global::Botpress.ChatCreateMessageRequestPayloadMarkdown, global::Botpress.ChatCreateMessageRequestPayloadText, global::Botpress.ChatCreateMessageRequestPayloadVideo> Payload { get; set; }

        /// <summary>
        /// ID of the [Conversation](#schema_conversation)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateMessageRequest" /> class.
        /// </summary>
        /// <param name="payload">
        /// Payload is the content type of the message.
        /// </param>
        /// <param name="conversationId">
        /// ID of the [Conversation](#schema_conversation)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCreateMessageRequest(
            global::Botpress.OneOf<global::Botpress.ChatCreateMessageRequestPayloadAudio, global::Botpress.ChatCreateMessageRequestPayloadCard, global::Botpress.ChatCreateMessageRequestPayloadCarousel, global::Botpress.ChatCreateMessageRequestPayloadChoice, global::Botpress.ChatCreateMessageRequestPayloadDropdown, global::Botpress.ChatCreateMessageRequestPayloadFile, global::Botpress.ChatCreateMessageRequestPayloadImage, global::Botpress.ChatCreateMessageRequestPayloadLocation, global::Botpress.ChatCreateMessageRequestPayloadMarkdown, global::Botpress.ChatCreateMessageRequestPayloadText, global::Botpress.ChatCreateMessageRequestPayloadVideo> payload,
            string conversationId)
        {
            this.Payload = payload;
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateMessageRequest" /> class.
        /// </summary>
        public ChatCreateMessageRequest()
        {
        }
    }
}