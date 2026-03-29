
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Conversation object configuration
    /// </summary>
    public sealed partial class AdminIntegrationChannelsConversation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationChannelsConversationTags2> Tags { get; set; }

        /// <summary>
        /// The conversation creation setting determines how to create a conversation through the API directly. The integration will have to implement the `createConversation` functionality to support this setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminIntegrationChannelsConversationCreation Creation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationChannelsConversation" /> class.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="creation">
        /// The conversation creation setting determines how to create a conversation through the API directly. The integration will have to implement the `createConversation` functionality to support this setting.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminIntegrationChannelsConversation(
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationChannelsConversationTags2> tags,
            global::Botpress.AdminIntegrationChannelsConversationCreation creation)
        {
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Creation = creation ?? throw new global::System.ArgumentNullException(nameof(creation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationChannelsConversation" /> class.
        /// </summary>
        public AdminIntegrationChannelsConversation()
        {
        }
    }
}