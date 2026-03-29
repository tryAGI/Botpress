
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Payload is the content type of the message. Accepted payload options: Text, Image, Choice, Dropdown, Card, Carousel, File, Audio, Video, Location
    /// </summary>
    public sealed partial class RuntimeMessagePayload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}