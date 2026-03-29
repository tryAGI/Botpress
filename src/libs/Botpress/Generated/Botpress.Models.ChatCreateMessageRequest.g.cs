
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatCreateMessageRequestPayloadVariant1, global::Botpress.ChatCreateMessageRequestPayloadVariant2, global::Botpress.ChatCreateMessageRequestPayloadVariant3, global::Botpress.ChatCreateMessageRequestPayloadVariant4, global::Botpress.ChatCreateMessageRequestPayloadVariant5, global::Botpress.ChatCreateMessageRequestPayloadVariant6, global::Botpress.ChatCreateMessageRequestPayloadVariant7, global::Botpress.ChatCreateMessageRequestPayloadVariant8, global::Botpress.ChatCreateMessageRequestPayloadVariant9, global::Botpress.ChatCreateMessageRequestPayloadVariant10, global::Botpress.ChatCreateMessageRequestPayloadVariant11>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.OneOf<global::Botpress.ChatCreateMessageRequestPayloadVariant1, global::Botpress.ChatCreateMessageRequestPayloadVariant2, global::Botpress.ChatCreateMessageRequestPayloadVariant3, global::Botpress.ChatCreateMessageRequestPayloadVariant4, global::Botpress.ChatCreateMessageRequestPayloadVariant5, global::Botpress.ChatCreateMessageRequestPayloadVariant6, global::Botpress.ChatCreateMessageRequestPayloadVariant7, global::Botpress.ChatCreateMessageRequestPayloadVariant8, global::Botpress.ChatCreateMessageRequestPayloadVariant9, global::Botpress.ChatCreateMessageRequestPayloadVariant10, global::Botpress.ChatCreateMessageRequestPayloadVariant11> Payload { get; set; }

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
            global::Botpress.OneOf<global::Botpress.ChatCreateMessageRequestPayloadVariant1, global::Botpress.ChatCreateMessageRequestPayloadVariant2, global::Botpress.ChatCreateMessageRequestPayloadVariant3, global::Botpress.ChatCreateMessageRequestPayloadVariant4, global::Botpress.ChatCreateMessageRequestPayloadVariant5, global::Botpress.ChatCreateMessageRequestPayloadVariant6, global::Botpress.ChatCreateMessageRequestPayloadVariant7, global::Botpress.ChatCreateMessageRequestPayloadVariant8, global::Botpress.ChatCreateMessageRequestPayloadVariant9, global::Botpress.ChatCreateMessageRequestPayloadVariant10, global::Botpress.ChatCreateMessageRequestPayloadVariant11> payload,
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