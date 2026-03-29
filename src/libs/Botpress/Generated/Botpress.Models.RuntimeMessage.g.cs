
#nullable enable

namespace Botpress
{
    /// <summary>
    /// The Message object represents a message in a [Conversation](#schema_conversation) for a specific [User](#schema_user).
    /// </summary>
    public sealed partial class RuntimeMessage
    {
        /// <summary>
        /// Id of the [Message](#schema_message)
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
        /// Update date of the [Message](#schema_message) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Type of the [Message](#schema_message) represents the resource type that the message is related to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Payload is the content type of the message. Accepted payload options: Text, Image, Choice, Dropdown, Card, Carousel, File, Audio, Video, Location
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Payload { get; set; }

        /// <summary>
        /// Direction of the message (`incoming` or `outgoing`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.RuntimeMessageDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.RuntimeMessageDirection Direction { get; set; }

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
        /// Set of [Tags](/docs/developers/concepts/tags) that you can attach to a [Conversation](#schema_conversation). The set of [Tags](/docs/developers/concepts/tags) available on a [Conversation](#schema_conversation) is restricted by the list of [Tags](/docs/developers/concepts/tags) defined previously by the [Bot](#schema_bot). Individual keys can be unset by posting an empty value to them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Origin of the message (`synthetic`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.RuntimeMessageOriginJsonConverter))]
        public global::Botpress.RuntimeMessageOrigin? Origin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the [Message](#schema_message)
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the [Message](#schema_message) in ISO 8601 format
        /// </param>
        /// <param name="updatedAt">
        /// Update date of the [Message](#schema_message) in ISO 8601 format
        /// </param>
        /// <param name="type">
        /// Type of the [Message](#schema_message) represents the resource type that the message is related to
        /// </param>
        /// <param name="payload">
        /// Payload is the content type of the message. Accepted payload options: Text, Image, Choice, Dropdown, Card, Carousel, File, Audio, Video, Location
        /// </param>
        /// <param name="direction">
        /// Direction of the message (`incoming` or `outgoing`).
        /// </param>
        /// <param name="userId">
        /// ID of the [User](#schema_user)
        /// </param>
        /// <param name="conversationId">
        /// ID of the [Conversation](#schema_conversation)
        /// </param>
        /// <param name="tags">
        /// Set of [Tags](/docs/developers/concepts/tags) that you can attach to a [Conversation](#schema_conversation). The set of [Tags](/docs/developers/concepts/tags) available on a [Conversation](#schema_conversation) is restricted by the list of [Tags](/docs/developers/concepts/tags) defined previously by the [Bot](#schema_bot). Individual keys can be unset by posting an empty value to them.
        /// </param>
        /// <param name="origin">
        /// Origin of the message (`synthetic`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuntimeMessage(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string type,
            object payload,
            global::Botpress.RuntimeMessageDirection direction,
            string userId,
            string conversationId,
            global::System.Collections.Generic.Dictionary<string, string> tags,
            global::Botpress.RuntimeMessageOrigin? origin)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.Direction = direction;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeMessage" /> class.
        /// </summary>
        public RuntimeMessage()
        {
        }
    }
}