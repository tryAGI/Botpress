
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Identifier configuration of the [Integration](#schema_integration)
    /// </summary>
    public sealed partial class AdminIntegrationConfigurationsIdentifier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkTemplateScript")]
        public string? LinkTemplateScript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationConfigurationsIdentifier" /> class.
        /// </summary>
        /// <param name="required"></param>
        /// <param name="linkTemplateScript"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminIntegrationConfigurationsIdentifier(
            bool required,
            string? linkTemplateScript)
        {
            this.LinkTemplateScript = linkTemplateScript;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationConfigurationsIdentifier" /> class.
        /// </summary>
        public AdminIntegrationConfigurationsIdentifier()
        {
        }
    }
}