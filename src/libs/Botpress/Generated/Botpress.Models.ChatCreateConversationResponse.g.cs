
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCreateConversationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.ChatCreateConversationResponseConversation Conversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateConversationResponse" /> class.
        /// </summary>
        /// <param name="conversation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCreateConversationResponse(
            global::Botpress.ChatCreateConversationResponseConversation conversation)
        {
            this.Conversation = conversation ?? throw new global::System.ArgumentNullException(nameof(conversation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateConversationResponse" /> class.
        /// </summary>
        public ChatCreateConversationResponse()
        {
        }
    }
}