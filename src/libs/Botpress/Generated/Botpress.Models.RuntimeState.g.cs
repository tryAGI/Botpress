
#nullable enable

namespace Botpress
{
    /// <summary>
    /// The state object represents the current payload. A state is always linked to either a bot, a conversation or a user.
    /// </summary>
    public sealed partial class RuntimeState
    {
        /// <summary>
        /// Id of the [State](#schema_state)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation date of the [State](#schema_state) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Updating date of the [State](#schema_state) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Id of the [Bot](#schema_bot)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BotId { get; set; }

        /// <summary>
        /// Id of the [Conversation](#schema_conversation)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Id of the [User](#schema_user)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Name of the [State](#schema_state) which is declared inside the bot definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Type of the [State](#schema_state) represents the resource type (`conversation`, `user`, `bot`, `integration` or `workflow`) that the state is related to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.RuntimeStateTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.RuntimeStateType Type { get; set; }

        /// <summary>
        /// Payload is the content of the state defined by your bot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeState" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the [State](#schema_state)
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the [State](#schema_state) in ISO 8601 format
        /// </param>
        /// <param name="updatedAt">
        /// Updating date of the [State](#schema_state) in ISO 8601 format
        /// </param>
        /// <param name="botId">
        /// Id of the [Bot](#schema_bot)
        /// </param>
        /// <param name="name">
        /// Name of the [State](#schema_state) which is declared inside the bot definition
        /// </param>
        /// <param name="type">
        /// Type of the [State](#schema_state) represents the resource type (`conversation`, `user`, `bot`, `integration` or `workflow`) that the state is related to
        /// </param>
        /// <param name="payload">
        /// Payload is the content of the state defined by your bot.
        /// </param>
        /// <param name="conversationId">
        /// Id of the [Conversation](#schema_conversation)
        /// </param>
        /// <param name="userId">
        /// Id of the [User](#schema_user)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuntimeState(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string botId,
            string name,
            global::Botpress.RuntimeStateType type,
            object payload,
            string? conversationId,
            string? userId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.BotId = botId ?? throw new global::System.ArgumentNullException(nameof(botId));
            this.ConversationId = conversationId;
            this.UserId = userId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeState" /> class.
        /// </summary>
        public RuntimeState()
        {
        }
    }
}