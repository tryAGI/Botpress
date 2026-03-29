
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminPluginDependencies
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interfaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginDependenciesInterfaces2> Interfaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginDependenciesIntegrations2> Integrations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminPluginDependencies" /> class.
        /// </summary>
        /// <param name="interfaces"></param>
        /// <param name="integrations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminPluginDependencies(
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginDependenciesInterfaces2> interfaces,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginDependenciesIntegrations2> integrations)
        {
            this.Interfaces = interfaces ?? throw new global::System.ArgumentNullException(nameof(interfaces));
            this.Integrations = integrations ?? throw new global::System.ArgumentNullException(nameof(integrations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminPluginDependencies" /> class.
        /// </summary>
        public AdminPluginDependencies()
        {
        }
    }
}