
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Schema of the configuration in the `JSON schema` format. The configuration data is validated against this `JSON schema`.
    /// </summary>
    public sealed partial class AdminBotConfigurationSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}