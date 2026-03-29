
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatListMessagesResponseMessagePayloadVariant52
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessagePayloadVariant5Option2> Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant5Type2JsonConverter))]
        public global::Botpress.ChatListMessagesResponseMessagePayloadVariant5Type2 Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatListMessagesResponseMessagePayloadVariant52" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="options"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatListMessagesResponseMessagePayloadVariant52(
            string text,
            global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessagePayloadVariant5Option2> options,
            global::Botpress.ChatListMessagesResponseMessagePayloadVariant5Type2 type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatListMessagesResponseMessagePayloadVariant52" /> class.
        /// </summary>
        public ChatListMessagesResponseMessagePayloadVariant52()
        {
        }
    }
}