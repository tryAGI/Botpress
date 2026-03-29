
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Payload is the content of the event defined by the integration installed on your bot or one of the default events created by our api.
    /// </summary>
    public sealed partial class RuntimeEventPayload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}