
#nullable enable

namespace Botpress
{
    /// <summary>
    /// The event object represents an action or an occurrence.
    /// </summary>
    public sealed partial class RuntimeEvent
    {
        /// <summary>
        /// Id of the [Event](#schema_event)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation date of the [Event](#schema_event) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Type of the [Event](#schema_event).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Payload is the content of the event defined by the integration installed on your bot or one of the default events created by our api.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Payload { get; set; }

        /// <summary>
        /// ID of the [Conversation](#schema_conversation) to link the event to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// ID of the [User](#schema_user) to link the event to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// ID of the [Message](#schema_message) to link the event to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        public string? MessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.RuntimeEventStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.RuntimeEventStatus Status { get; set; }

        /// <summary>
        /// Reason why the event failed to be processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureReason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the [Event](#schema_event)
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the [Event](#schema_event) in ISO 8601 format
        /// </param>
        /// <param name="type">
        /// Type of the [Event](#schema_event).
        /// </param>
        /// <param name="payload">
        /// Payload is the content of the event defined by the integration installed on your bot or one of the default events created by our api.
        /// </param>
        /// <param name="status"></param>
        /// <param name="conversationId">
        /// ID of the [Conversation](#schema_conversation) to link the event to.
        /// </param>
        /// <param name="userId">
        /// ID of the [User](#schema_user) to link the event to.
        /// </param>
        /// <param name="messageId">
        /// ID of the [Message](#schema_message) to link the event to.
        /// </param>
        /// <param name="failureReason">
        /// Reason why the event failed to be processed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuntimeEvent(
            string id,
            global::System.DateTime createdAt,
            string type,
            object payload,
            global::Botpress.RuntimeEventStatus status,
            string? conversationId,
            string? userId,
            string? messageId,
            string? failureReason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.ConversationId = conversationId;
            this.UserId = userId;
            this.MessageId = messageId;
            this.Status = status;
            this.FailureReason = failureReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeEvent" /> class.
        /// </summary>
        public RuntimeEvent()
        {
        }
    }
}