
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatGetMessageResponseMessagePayloadVariant92
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Markdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant9Type2JsonConverter))]
        public global::Botpress.ChatGetMessageResponseMessagePayloadVariant9Type2 Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetMessageResponseMessagePayloadVariant92" /> class.
        /// </summary>
        /// <param name="markdown"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatGetMessageResponseMessagePayloadVariant92(
            string markdown,
            global::Botpress.ChatGetMessageResponseMessagePayloadVariant9Type2 type)
        {
            this.Markdown = markdown ?? throw new global::System.ArgumentNullException(nameof(markdown));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetMessageResponseMessagePayloadVariant92" /> class.
        /// </summary>
        public ChatGetMessageResponseMessagePayloadVariant92()
        {
        }
    }
}