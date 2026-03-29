
#nullable enable

namespace Botpress
{
    /// <summary>
    /// The Message object represents a message in a [Conversation](#schema_conversation) for a specific [User](#schema_user).
    /// </summary>
    public sealed partial class ChatGetMessageResponseMessage
    {
        /// <summary>
        /// Identifier of the [Message](#schema_message)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation date of the [Message](#schema_message) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Payload is the content type of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatGetMessageResponseMessagePayloadVariant1, global::Botpress.ChatGetMessageResponseMessagePayloadVariant2, global::Botpress.ChatGetMessageResponseMessagePayloadVariant3, global::Botpress.ChatGetMessageResponseMessagePayloadVariant4, global::Botpress.ChatGetMessageResponseMessagePayloadVariant5, global::Botpress.ChatGetMessageResponseMessagePayloadVariant6, global::Botpress.ChatGetMessageResponseMessagePayloadVariant7, global::Botpress.ChatGetMessageResponseMessagePayloadVariant8, global::Botpress.ChatGetMessageResponseMessagePayloadVariant9, global::Botpress.ChatGetMessageResponseMessagePayloadVariant10, global::Botpress.ChatGetMessageResponseMessagePayloadVariant11>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.OneOf<global::Botpress.ChatGetMessageResponseMessagePayloadVariant1, global::Botpress.ChatGetMessageResponseMessagePayloadVariant2, global::Botpress.ChatGetMessageResponseMessagePayloadVariant3, global::Botpress.ChatGetMessageResponseMessagePayloadVariant4, global::Botpress.ChatGetMessageResponseMessagePayloadVariant5, global::Botpress.ChatGetMessageResponseMessagePayloadVariant6, global::Botpress.ChatGetMessageResponseMessagePayloadVariant7, global::Botpress.ChatGetMessageResponseMessagePayloadVariant8, global::Botpress.ChatGetMessageResponseMessagePayloadVariant9, global::Botpress.ChatGetMessageResponseMessagePayloadVariant10, global::Botpress.ChatGetMessageResponseMessagePayloadVariant11> Payload { get; set; }

        /// <summary>
        /// ID of the [User](#schema_user)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatGetMessageResponseMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the [Message](#schema_message)
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the [Message](#schema_message) in ISO 8601 format
        /// </param>
        /// <param name="payload">
        /// Payload is the content type of the message.
        /// </param>
        /// <param name="userId">
        /// ID of the [User](#schema_user)
        /// </param>
        /// <param name="conversationId">
        /// ID of the [Conversation](#schema_conversation)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatGetMessageResponseMessage(
            string id,
            global::System.DateTime createdAt,
            global::Botpress.OneOf<global::Botpress.ChatGetMessageResponseMessagePayloadVariant1, global::Botpress.ChatGetMessageResponseMessagePayloadVariant2, global::Botpress.ChatGetMessageResponseMessagePayloadVariant3, global::Botpress.ChatGetMessageResponseMessagePayloadVariant4, global::Botpress.ChatGetMessageResponseMessagePayloadVariant5, global::Botpress.ChatGetMessageResponseMessagePayloadVariant6, global::Botpress.ChatGetMessageResponseMessagePayloadVariant7, global::Botpress.ChatGetMessageResponseMessagePayloadVariant8, global::Botpress.ChatGetMessageResponseMessagePayloadVariant9, global::Botpress.ChatGetMessageResponseMessagePayloadVariant10, global::Botpress.ChatGetMessageResponseMessagePayloadVariant11> payload,
            string userId,
            string conversationId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Payload = payload;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetMessageResponseMessage" /> class.
        /// </summary>
        public ChatGetMessageResponseMessage()
        {
        }
    }
}