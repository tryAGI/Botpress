
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminInterfaceChannels2
    {
        /// <summary>
        /// Title of the channel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description of the channel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceChannelsMessages2> Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminInterfaceChannels2" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="title">
        /// Title of the channel
        /// </param>
        /// <param name="description">
        /// Description of the channel
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminInterfaceChannels2(
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceChannelsMessages2> messages,
            string? title,
            string? description)
        {
            this.Title = title;
            this.Description = description;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminInterfaceChannels2" /> class.
        /// </summary>
        public AdminInterfaceChannels2()
        {
        }
    }
}