
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatListParticipantsResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("participants")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Botpress.ChatListParticipantsResponseParticipant2> Participants { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.ChatListParticipantsResponseMeta2 Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatListParticipantsResponse2" /> class.
        /// </summary>
        /// <param name="participants"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatListParticipantsResponse2(
            global::System.Collections.Generic.IList<global::Botpress.ChatListParticipantsResponseParticipant2> participants,
            global::Botpress.ChatListParticipantsResponseMeta2 meta)
        {
            this.Participants = participants ?? throw new global::System.ArgumentNullException(nameof(participants));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatListParticipantsResponse2" /> class.
        /// </summary>
        public ChatListParticipantsResponse2()
        {
        }
    }
}