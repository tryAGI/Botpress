
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Botpress
{
    /// <summary>
    /// The [Conversation](#schema_conversation) object represents an exchange of messages between one or more users. A [Conversation](#schema_conversation) is always linked to an integration's channels. For example, a Slack channel represents a conversation.
    /// </summary>
    public sealed partial class RuntimeConversation
    {
        /// <summary>
        /// Id of the [Conversation](#schema_conversation)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unused. This field will be removed in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentTaskId")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? CurrentTaskId { get; set; }

        /// <summary>
        /// Id of the current [Workflow](#schema_workflow)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentWorkflowId")]
        public string? CurrentWorkflowId { get; set; }

        /// <summary>
        /// Creation date of the [Conversation](#schema_conversation) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Updating date of the [Conversation](#schema_conversation) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Name of the channel where the [Conversation](#schema_conversation) is happening
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Channel { get; set; }

        /// <summary>
        /// Name of the integration that created the [Conversation](#schema_conversation)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Integration { get; set; }

        /// <summary>
        /// Set of [Tags](/docs/developers/concepts/tags) that you can attach to a [Conversation](#schema_conversation). The set of [Tags](/docs/developers/concepts/tags) available on a [Conversation](#schema_conversation) is restricted by the list of [Tags](/docs/developers/concepts/tags) defined previously by the [Bot](#schema_bot). Individual keys can be unset by posting an empty value to them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Number of messages in the conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MessageCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeConversation" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the [Conversation](#schema_conversation)
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the [Conversation](#schema_conversation) in ISO 8601 format
        /// </param>
        /// <param name="updatedAt">
        /// Updating date of the [Conversation](#schema_conversation) in ISO 8601 format
        /// </param>
        /// <param name="channel">
        /// Name of the channel where the [Conversation](#schema_conversation) is happening
        /// </param>
        /// <param name="integration">
        /// Name of the integration that created the [Conversation](#schema_conversation)
        /// </param>
        /// <param name="tags">
        /// Set of [Tags](/docs/developers/concepts/tags) that you can attach to a [Conversation](#schema_conversation). The set of [Tags](/docs/developers/concepts/tags) available on a [Conversation](#schema_conversation) is restricted by the list of [Tags](/docs/developers/concepts/tags) defined previously by the [Bot](#schema_bot). Individual keys can be unset by posting an empty value to them.
        /// </param>
        /// <param name="messageCount">
        /// Number of messages in the conversation
        /// </param>
        /// <param name="currentWorkflowId">
        /// Id of the current [Workflow](#schema_workflow)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuntimeConversation(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string channel,
            string integration,
            global::System.Collections.Generic.Dictionary<string, string> tags,
            double messageCount,
            string? currentWorkflowId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CurrentWorkflowId = currentWorkflowId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Channel = channel ?? throw new global::System.ArgumentNullException(nameof(channel));
            this.Integration = integration ?? throw new global::System.ArgumentNullException(nameof(integration));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.MessageCount = messageCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeConversation" /> class.
        /// </summary>
        public RuntimeConversation()
        {
        }
    }
}