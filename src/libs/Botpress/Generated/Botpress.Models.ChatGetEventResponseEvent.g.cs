
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatGetEventResponseEvent
    {
        /// <summary>
        /// ID of the custom [Event](#schema_event).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation date of the custom [Event](#schema_event) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Payload is the content of the custom event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Payload { get; set; }

        /// <summary>
        /// ID of the [Conversation](#schema_conversation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// ID of the [User](#schema_user).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetEventResponseEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the custom [Event](#schema_event).
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the custom [Event](#schema_event) in ISO 8601 format
        /// </param>
        /// <param name="payload">
        /// Payload is the content of the custom event.
        /// </param>
        /// <param name="conversationId">
        /// ID of the [Conversation](#schema_conversation).
        /// </param>
        /// <param name="userId">
        /// ID of the [User](#schema_user).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatGetEventResponseEvent(
            string id,
            global::System.DateTime createdAt,
            object payload,
            string conversationId,
            string userId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetEventResponseEvent" /> class.
        /// </summary>
        public ChatGetEventResponseEvent()
        {
        }
    }
}