
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCreateMessageResponseMessagePayloadVariant5
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
        public required global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5Option> Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant5TypeJsonConverter))]
        public global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateMessageResponseMessagePayloadVariant5" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="options"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCreateMessageResponseMessagePayloadVariant5(
            string text,
            global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5Option> options,
            global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5Type type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateMessageResponseMessagePayloadVariant5" /> class.
        /// </summary>
        public ChatCreateMessageResponseMessagePayloadVariant5()
        {
        }
    }
}