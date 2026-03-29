
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCreateMessageResponseMessagePayloadVariant62
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant6Type2JsonConverter))]
        public global::Botpress.ChatCreateMessageResponseMessagePayloadVariant6Type2 Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateMessageResponseMessagePayloadVariant62" /> class.
        /// </summary>
        /// <param name="fileUrl"></param>
        /// <param name="title"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCreateMessageResponseMessagePayloadVariant62(
            string fileUrl,
            string? title,
            global::Botpress.ChatCreateMessageResponseMessagePayloadVariant6Type2 type)
        {
            this.FileUrl = fileUrl ?? throw new global::System.ArgumentNullException(nameof(fileUrl));
            this.Title = title;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateMessageResponseMessagePayloadVariant62" /> class.
        /// </summary>
        public ChatCreateMessageResponseMessagePayloadVariant62()
        {
        }
    }
}