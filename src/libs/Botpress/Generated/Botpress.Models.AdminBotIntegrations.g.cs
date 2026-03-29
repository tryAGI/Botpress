
#nullable enable

namespace Botpress
{
    /// <summary>
    /// A mapping of integrations to their configuration. If the `x-multiple-integrations` header is present, this object is keyed by integration aliases. Otherwise, this object is keyed by integration ids.
    /// </summary>
    public sealed partial class AdminBotIntegrations
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}