
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatGetParticipantResponse
    {
        /// <summary>
        /// The user object represents someone interacting with the bot within a specific integration. The same person interacting with a bot in slack and messenger will be represented with two different users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("participant")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.ChatGetParticipantResponseParticipant Participant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetParticipantResponse" /> class.
        /// </summary>
        /// <param name="participant">
        /// The user object represents someone interacting with the bot within a specific integration. The same person interacting with a bot in slack and messenger will be represented with two different users.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatGetParticipantResponse(
            global::Botpress.ChatGetParticipantResponseParticipant participant)
        {
            this.Participant = participant ?? throw new global::System.ArgumentNullException(nameof(participant));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetParticipantResponse" /> class.
        /// </summary>
        public ChatGetParticipantResponse()
        {
        }
    }
}