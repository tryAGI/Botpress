
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCreateMessageRequestPayloadVideo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVideoTypeJsonConverter))]
        public global::Botpress.ChatCreateMessageRequestPayloadVideoType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateMessageRequestPayloadVideo" /> class.
        /// </summary>
        /// <param name="videoUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCreateMessageRequestPayloadVideo(
            string videoUrl,
            global::Botpress.ChatCreateMessageRequestPayloadVideoType type)
        {
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateMessageRequestPayloadVideo" /> class.
        /// </summary>
        public ChatCreateMessageRequestPayloadVideo()
        {
        }
    }
}