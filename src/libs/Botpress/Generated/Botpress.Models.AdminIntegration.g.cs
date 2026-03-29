
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminIntegration
    {
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
        /// Global identifier configuration of the [Integration](#schema_integration)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminIntegrationIdentifier Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox")]
        public global::Botpress.AdminIntegrationSandbox? Sandbox { get; set; }

        /// <summary>
        /// Maximum execution time of the integration (in seconds).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxExecutionTime")]
        public double? MaxExecutionTime { get; set; }

        /// <summary>
        /// URL of the [Integration](#schema_integration)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Signing secret of the [Integration](#schema_integration). This field is only visible when creating a new integration or when rotating the signing secret of an existing integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signingSecret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SigningSecret { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("interfaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfaces2> Interfaces { get; set; }

        /// <summary>
        /// Configuration definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminIntegrationConfiguration Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationConfigurations2> Configurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationChannels2> Channels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("states")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationStates2> States { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationEvents2> Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationActions2> Actions { get; set; }

        /// <summary>
        /// User object configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminIntegrationUser User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationEntities2> Entities { get; set; }

        /// <summary>
        /// Optional attributes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attributes { get; set; }

        /// <summary>
        /// Indicates if the integration is a development integration; Dev integrations run locally
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dev")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Dev { get; set; }

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
        /// URL of the readme of the integration. This is the readme that will be displayed in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readmeUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReadmeUrl { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminIntegrationVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminIntegrationVisibility Visibility { get; set; }

        /// <summary>
        /// Status of the integration version verification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verificationStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminIntegrationVerificationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminIntegrationVerificationStatus VerificationStatus { get; set; }

        /// <summary>
        /// The lifecycle status of the integration. When an integration is deprecated, it can no longer be installed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycleStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminIntegrationLifecycleStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminIntegrationLifecycleStatus LifecycleStatus { get; set; }

        /// <summary>
        /// Secrets are integration-wide values available in the code via environment variables formatted with a SECRET_ prefix followed by your secret name. A secret name must respect SCREAMING_SNAKE casing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegration" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the [Integration](#schema_integration)
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the [Integration](#schema_integration) in ISO 8601 format
        /// </param>
        /// <param name="updatedAt">
        /// Updating date of the [Integration](#schema_integration) in ISO 8601 format
        /// </param>
        /// <param name="identifier">
        /// Global identifier configuration of the [Integration](#schema_integration)
        /// </param>
        /// <param name="url">
        /// URL of the [Integration](#schema_integration)
        /// </param>
        /// <param name="signingSecret">
        /// Signing secret of the [Integration](#schema_integration). This field is only visible when creating a new integration or when rotating the signing secret of an existing integration.
        /// </param>
        /// <param name="name">
        /// Name of the [Integration](#schema_integration)
        /// </param>
        /// <param name="version">
        /// Version of the [Integration](#schema_integration)
        /// </param>
        /// <param name="interfaces"></param>
        /// <param name="configuration">
        /// Configuration definition
        /// </param>
        /// <param name="configurations"></param>
        /// <param name="channels"></param>
        /// <param name="states"></param>
        /// <param name="events"></param>
        /// <param name="actions"></param>
        /// <param name="user">
        /// User object configuration
        /// </param>
        /// <param name="entities"></param>
        /// <param name="dev">
        /// Indicates if the integration is a development integration; Dev integrations run locally
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
        /// <param name="readmeUrl">
        /// URL of the readme of the integration. This is the readme that will be displayed in the UI
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
        /// <param name="secrets">
        /// Secrets are integration-wide values available in the code via environment variables formatted with a SECRET_ prefix followed by your secret name. A secret name must respect SCREAMING_SNAKE casing.
        /// </param>
        /// <param name="sandbox"></param>
        /// <param name="maxExecutionTime">
        /// Maximum execution time of the integration (in seconds).
        /// </param>
        /// <param name="attributes">
        /// Optional attributes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminIntegration(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Botpress.AdminIntegrationIdentifier identifier,
            string url,
            string signingSecret,
            string name,
            string version,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfaces2> interfaces,
            global::Botpress.AdminIntegrationConfiguration configuration,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationConfigurations2> configurations,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationChannels2> channels,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationStates2> states,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationEvents2> events,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationActions2> actions,
            global::Botpress.AdminIntegrationUser user,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationEntities2> entities,
            bool dev,
            string title,
            string description,
            string iconUrl,
            string readmeUrl,
            bool @public,
            global::Botpress.AdminIntegrationVisibility visibility,
            global::Botpress.AdminIntegrationVerificationStatus verificationStatus,
            global::Botpress.AdminIntegrationLifecycleStatus lifecycleStatus,
            global::System.Collections.Generic.IList<string> secrets,
            global::Botpress.AdminIntegrationSandbox? sandbox,
            double? maxExecutionTime,
            global::System.Collections.Generic.Dictionary<string, string>? attributes)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Sandbox = sandbox;
            this.MaxExecutionTime = maxExecutionTime;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.SigningSecret = signingSecret ?? throw new global::System.ArgumentNullException(nameof(signingSecret));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Interfaces = interfaces ?? throw new global::System.ArgumentNullException(nameof(interfaces));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Configurations = configurations ?? throw new global::System.ArgumentNullException(nameof(configurations));
            this.Channels = channels ?? throw new global::System.ArgumentNullException(nameof(channels));
            this.States = states ?? throw new global::System.ArgumentNullException(nameof(states));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
            this.Attributes = attributes;
            this.Dev = dev;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IconUrl = iconUrl ?? throw new global::System.ArgumentNullException(nameof(iconUrl));
            this.ReadmeUrl = readmeUrl ?? throw new global::System.ArgumentNullException(nameof(readmeUrl));
            this.Public = @public;
            this.Visibility = visibility;
            this.VerificationStatus = verificationStatus;
            this.LifecycleStatus = lifecycleStatus;
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegration" /> class.
        /// </summary>
        public AdminIntegration()
        {
        }
    }
}