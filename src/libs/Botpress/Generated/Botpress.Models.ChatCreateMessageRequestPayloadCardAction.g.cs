
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCreateMessageRequestPayloadCardAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadCardActionActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.ChatCreateMessageRequestPayloadCardActionAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateMessageRequestPayloadCardAction" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="label"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCreateMessageRequestPayloadCardAction(
            global::Botpress.ChatCreateMessageRequestPayloadCardActionAction action,
            string label,
            string value)
        {
            this.Action = action;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCreateMessageRequestPayloadCardAction" /> class.
        /// </summary>
        public ChatCreateMessageRequestPayloadCardAction()
        {
        }
    }
}