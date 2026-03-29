
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatListMessagesResponseMessagePayloadVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitle")]
        public string? Subtitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessagePayloadVariant2Action> Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2TypeJsonConverter))]
        public global::Botpress.ChatListMessagesResponseMessagePayloadVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatListMessagesResponseMessagePayloadVariant2" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="actions"></param>
        /// <param name="subtitle"></param>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatListMessagesResponseMessagePayloadVariant2(
            string title,
            global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessagePayloadVariant2Action> actions,
            string? subtitle,
            string? imageUrl,
            global::Botpress.ChatListMessagesResponseMessagePayloadVariant2Type type)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Subtitle = subtitle;
            this.ImageUrl = imageUrl;
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatListMessagesResponseMessagePayloadVariant2" /> class.
        /// </summary>
        public ChatListMessagesResponseMessagePayloadVariant2()
        {
        }
    }
}