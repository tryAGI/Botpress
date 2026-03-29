
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessagePayloadVariant4
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
        public required global::System.Collections.Generic.IList<global::Botpress.ChatMessagePayloadVariant4Option> Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant4TypeJsonConverter))]
        public global::Botpress.ChatMessagePayloadVariant4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessagePayloadVariant4" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="options"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMessagePayloadVariant4(
            string text,
            global::System.Collections.Generic.IList<global::Botpress.ChatMessagePayloadVariant4Option> options,
            global::Botpress.ChatMessagePayloadVariant4Type type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessagePayloadVariant4" /> class.
        /// </summary>
        public ChatMessagePayloadVariant4()
        {
        }
    }
}