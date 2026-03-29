
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Channel definition
    /// </summary>
    public sealed partial class AdminIntegrationChannels2
    {
        /// <summary>
        /// Title of the channel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description of the channel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationChannelsMessages2> Messages { get; set; }

        /// <summary>
        /// Conversation object configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminIntegrationChannelsConversation Conversation { get; set; }

        /// <summary>
        /// Message object configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminIntegrationChannelsMessage Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationChannels2" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="conversation">
        /// Conversation object configuration
        /// </param>
        /// <param name="message">
        /// Message object configuration
        /// </param>
        /// <param name="title">
        /// Title of the channel
        /// </param>
        /// <param name="description">
        /// Description of the channel
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminIntegrationChannels2(
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationChannelsMessages2> messages,
            global::Botpress.AdminIntegrationChannelsConversation conversation,
            global::Botpress.AdminIntegrationChannelsMessage message,
            string? title,
            string? description)
        {
            this.Title = title;
            this.Description = description;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Conversation = conversation ?? throw new global::System.ArgumentNullException(nameof(conversation));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationChannels2" /> class.
        /// </summary>
        public AdminIntegrationChannels2()
        {
        }
    }
}