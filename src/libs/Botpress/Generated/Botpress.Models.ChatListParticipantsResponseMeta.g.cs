
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatListParticipantsResponseMeta
    {
        /// <summary>
        /// The token to use to retrieve the next page of results, passed as a query string parameter (value should be URL-encoded) to this API endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextToken")]
        public string? NextToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatListParticipantsResponseMeta" /> class.
        /// </summary>
        /// <param name="nextToken">
        /// The token to use to retrieve the next page of results, passed as a query string parameter (value should be URL-encoded) to this API endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatListParticipantsResponseMeta(
            string? nextToken)
        {
            this.NextToken = nextToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatListParticipantsResponseMeta" /> class.
        /// </summary>
        public ChatListParticipantsResponseMeta()
        {
        }
    }
}