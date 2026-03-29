
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatListConversationsResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Botpress.ChatListConversationsResponseConversation2> Conversations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.ChatListConversationsResponseMeta2 Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatListConversationsResponse2" /> class.
        /// </summary>
        /// <param name="conversations"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatListConversationsResponse2(
            global::System.Collections.Generic.IList<global::Botpress.ChatListConversationsResponseConversation2> conversations,
            global::Botpress.ChatListConversationsResponseMeta2 meta)
        {
            this.Conversations = conversations ?? throw new global::System.ArgumentNullException(nameof(conversations));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatListConversationsResponse2" /> class.
        /// </summary>
        public ChatListConversationsResponse2()
        {
        }
    }
}