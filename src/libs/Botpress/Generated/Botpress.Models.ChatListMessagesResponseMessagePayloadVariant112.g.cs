
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatListMessagesResponseMessagePayloadVariant112
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant11Type2JsonConverter))]
        public global::Botpress.ChatListMessagesResponseMessagePayloadVariant11Type2 Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatListMessagesResponseMessagePayloadVariant112" /> class.
        /// </summary>
        /// <param name="videoUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatListMessagesResponseMessagePayloadVariant112(
            string videoUrl,
            global::Botpress.ChatListMessagesResponseMessagePayloadVariant11Type2 type)
        {
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatListMessagesResponseMessagePayloadVariant112" /> class.
        /// </summary>
        public ChatListMessagesResponseMessagePayloadVariant112()
        {
        }
    }
}