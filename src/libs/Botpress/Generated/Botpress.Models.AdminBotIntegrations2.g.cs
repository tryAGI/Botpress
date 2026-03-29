
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminBotIntegrations2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Name of the [Integration](#schema_integration)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Version of the [Integration](#schema_integration)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationType")]
        public string? ConfigurationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminBotIntegrationsStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminBotIntegrationsStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusReason")]
        public string? StatusReason { get; set; }

        /// <summary>
        /// Disabled channels for this integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledChannels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DisabledChannels { get; set; }

        /// <summary>
        /// ID of the [Integration](#schema_integration)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation date of the [Integration](#schema_integration) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Updating date of the [Integration](#schema_integration) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Title of the integration. This is the name that will be displayed in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Description of the integration. This is the description that will be displayed in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// URL of the icon of the integration. This is the icon that will be displayed in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iconUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IconUrl { get; set; }

        /// <summary>
        /// [DEPRECATED] Indicates whether the integration is public. Please use the "visibility" parameter instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// The integration's visibility. Public integrations are available to all and cannot be updated without creating a new version. Unlisted integrations behave identically to public integrations, but they are not listed in the integration hub. By default, integrations are private and only accessible to the workspace that created them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminBotIntegrationsVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminBotIntegrationsVisibility Visibility { get; set; }

        /// <summary>
        /// Status of the integration version verification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verificationStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminBotIntegrationsVerificationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminBotIntegrationsVerificationStatus VerificationStatus { get; set; }

        /// <summary>
        /// The lifecycle status of the integration. When an integration is deprecated, it can no longer be installed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycleStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminBotIntegrationsLifecycleStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminBotIntegrationsLifecycleStatus LifecycleStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotIntegrations2" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="name">
        /// Name of the [Integration](#schema_integration)
        /// </param>
        /// <param name="version">
        /// Version of the [Integration](#schema_integration)
        /// </param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookId"></param>
        /// <param name="configuration"></param>
        /// <param name="status"></param>
        /// <param name="disabledChannels">
        /// Disabled channels for this integration
        /// </param>
        /// <param name="id">
        /// ID of the [Integration](#schema_integration)
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the [Integration](#schema_integration) in ISO 8601 format
        /// </param>
        /// <param name="updatedAt">
        /// Updating date of the [Integration](#schema_integration) in ISO 8601 format
        /// </param>
        /// <param name="title">
        /// Title of the integration. This is the name that will be displayed in the UI
        /// </param>
        /// <param name="description">
        /// Description of the integration. This is the description that will be displayed in the UI
        /// </param>
        /// <param name="iconUrl">
        /// URL of the icon of the integration. This is the icon that will be displayed in the UI
        /// </param>
        /// <param name="public">
        /// [DEPRECATED] Indicates whether the integration is public. Please use the "visibility" parameter instead.
        /// </param>
        /// <param name="visibility">
        /// The integration's visibility. Public integrations are available to all and cannot be updated without creating a new version. Unlisted integrations behave identically to public integrations, but they are not listed in the integration hub. By default, integrations are private and only accessible to the workspace that created them.
        /// </param>
        /// <param name="verificationStatus">
        /// Status of the integration version verification
        /// </param>
        /// <param name="lifecycleStatus">
        /// The lifecycle status of the integration. When an integration is deprecated, it can no longer be installed.
        /// </param>
        /// <param name="identifier"></param>
        /// <param name="configurationType"></param>
        /// <param name="statusReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminBotIntegrations2(
            bool enabled,
            string name,
            string version,
            string webhookUrl,
            string webhookId,
            object configuration,
            global::Botpress.AdminBotIntegrationsStatus status,
            global::System.Collections.Generic.IList<string> disabledChannels,
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string title,
            string description,
            string iconUrl,
            bool @public,
            global::Botpress.AdminBotIntegrationsVisibility visibility,
            global::Botpress.AdminBotIntegrationsVerificationStatus verificationStatus,
            global::Botpress.AdminBotIntegrationsLifecycleStatus lifecycleStatus,
            string? identifier,
            string? configurationType,
            string? statusReason)
        {
            this.Enabled = enabled;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.WebhookId = webhookId ?? throw new global::System.ArgumentNullException(nameof(webhookId));
            this.Identifier = identifier;
            this.ConfigurationType = configurationType;
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Status = status;
            this.StatusReason = statusReason;
            this.DisabledChannels = disabledChannels ?? throw new global::System.ArgumentNullException(nameof(disabledChannels));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IconUrl = iconUrl ?? throw new global::System.ArgumentNullException(nameof(iconUrl));
            this.Public = @public;
            this.Visibility = visibility;
            this.VerificationStatus = verificationStatus;
            this.LifecycleStatus = lifecycleStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotIntegrations2" /> class.
        /// </summary>
        public AdminBotIntegrations2()
        {
        }
    }
}