
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminBotPluginsInterfaces2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationAlias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationAlias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationInterfaceAlias")]
        public string? IntegrationInterfaceAlias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interfaceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InterfaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotPluginsInterfaces2" /> class.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="integrationAlias"></param>
        /// <param name="interfaceId"></param>
        /// <param name="integrationInterfaceAlias"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminBotPluginsInterfaces2(
            string integrationId,
            string integrationAlias,
            string interfaceId,
            string? integrationInterfaceAlias)
        {
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.IntegrationAlias = integrationAlias ?? throw new global::System.ArgumentNullException(nameof(integrationAlias));
            this.IntegrationInterfaceAlias = integrationInterfaceAlias;
            this.InterfaceId = interfaceId ?? throw new global::System.ArgumentNullException(nameof(interfaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotPluginsInterfaces2" /> class.
        /// </summary>
        public AdminBotPluginsInterfaces2()
        {
        }
    }
}