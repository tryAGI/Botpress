
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Payload is the content of the state defined by your bot.
    /// </summary>
    public sealed partial class RuntimeStatePayload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}