
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatGetMessageResponse
    {
        /// <summary>
        /// The Message object represents a message in a [Conversation](#schema_conversation) for a specific [User](#schema_user).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.ChatGetMessageResponseMessage Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetMessageResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// The Message object represents a message in a [Conversation](#schema_conversation) for a specific [User](#schema_user).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatGetMessageResponse(
            global::Botpress.ChatGetMessageResponseMessage message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetMessageResponse" /> class.
        /// </summary>
        public ChatGetMessageResponse()
        {
        }
    }
}