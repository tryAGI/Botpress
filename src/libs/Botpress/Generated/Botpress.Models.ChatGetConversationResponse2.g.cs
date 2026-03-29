
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatGetConversationResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.ChatGetConversationResponseConversation2 Conversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetConversationResponse2" /> class.
        /// </summary>
        /// <param name="conversation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatGetConversationResponse2(
            global::Botpress.ChatGetConversationResponseConversation2 conversation)
        {
            this.Conversation = conversation ?? throw new global::System.ArgumentNullException(nameof(conversation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetConversationResponse2" /> class.
        /// </summary>
        public ChatGetConversationResponse2()
        {
        }
    }
}