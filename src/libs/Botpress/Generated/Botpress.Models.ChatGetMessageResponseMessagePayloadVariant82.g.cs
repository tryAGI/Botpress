
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatGetMessageResponseMessagePayloadVariant82
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latitude")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Latitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longitude")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Longitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant8Type2JsonConverter))]
        public global::Botpress.ChatGetMessageResponseMessagePayloadVariant8Type2 Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetMessageResponseMessagePayloadVariant82" /> class.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="address"></param>
        /// <param name="title"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatGetMessageResponseMessagePayloadVariant82(
            double latitude,
            double longitude,
            string? address,
            string? title,
            global::Botpress.ChatGetMessageResponseMessagePayloadVariant8Type2 type)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Address = address;
            this.Title = title;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetMessageResponseMessagePayloadVariant82" /> class.
        /// </summary>
        public ChatGetMessageResponseMessagePayloadVariant82()
        {
        }
    }
}