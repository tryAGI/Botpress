
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Configuration definition
    /// </summary>
    public sealed partial class AdminIntegrationConfigurations2
    {
        /// <summary>
        /// Title of the configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description of the configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Identifier configuration of the [Integration](#schema_integration)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminIntegrationConfigurationsIdentifier Identifier { get; set; }

        /// <summary>
        /// Schema of the configuration in the `JSON schema` format. The configuration data is validated against this `JSON schema`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationConfigurations2" /> class.
        /// </summary>
        /// <param name="identifier">
        /// Identifier configuration of the [Integration](#schema_integration)
        /// </param>
        /// <param name="schema">
        /// Schema of the configuration in the `JSON schema` format. The configuration data is validated against this `JSON schema`.
        /// </param>
        /// <param name="title">
        /// Title of the configuration
        /// </param>
        /// <param name="description">
        /// Description of the configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminIntegrationConfigurations2(
            global::Botpress.AdminIntegrationConfigurationsIdentifier identifier,
            object schema,
            string? title,
            string? description)
        {
            this.Title = title;
            this.Description = description;
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationConfigurations2" /> class.
        /// </summary>
        public AdminIntegrationConfigurations2()
        {
        }
    }
}