
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCreateMessageRequestPayloadCarousel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageRequestPayloadCarouselItem> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadCarouselTypeJsonConverter))]
        public global::Botpress.ChatCreateMessageRequestPayloadCarouselType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateMessageRequestPayloadCarousel" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCreateMessageRequestPayloadCarousel(
            global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageRequestPayloadCarouselItem> items,
            global::Botpress.ChatCreateMessageRequestPayloadCarouselType type)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateMessageRequestPayloadCarousel" /> class.
        /// </summary>
        public ChatCreateMessageRequestPayloadCarousel()
        {
        }
    }
}