
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatGetMessageResponseMessagePayloadVariant32
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Botpress.ChatGetMessageResponseMessagePayloadVariant3Item2> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3Type2JsonConverter))]
        public global::Botpress.ChatGetMessageResponseMessagePayloadVariant3Type2 Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetMessageResponseMessagePayloadVariant32" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatGetMessageResponseMessagePayloadVariant32(
            global::System.Collections.Generic.IList<global::Botpress.ChatGetMessageResponseMessagePayloadVariant3Item2> items,
            global::Botpress.ChatGetMessageResponseMessagePayloadVariant3Type2 type)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetMessageResponseMessagePayloadVariant32" /> class.
        /// </summary>
        public ChatGetMessageResponseMessagePayloadVariant32()
        {
        }
    }
}