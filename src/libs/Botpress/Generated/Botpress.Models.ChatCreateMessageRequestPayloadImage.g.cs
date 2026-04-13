
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCreateMessageRequestPayloadImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadImageTypeJsonConverter))]
        public global::Botpress.ChatCreateMessageRequestPayloadImageType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateMessageRequestPayloadImage" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCreateMessageRequestPayloadImage(
            string imageUrl,
            global::Botpress.ChatCreateMessageRequestPayloadImageType type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateMessageRequestPayloadImage" /> class.
        /// </summary>
        public ChatCreateMessageRequestPayloadImage()
        {
        }
    }
}