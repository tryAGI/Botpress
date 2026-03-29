
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminBotPlugins2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Name of the [Plugin](#schema_plugin)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Version of the [Plugin](#schema_plugin)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Configuration { get; set; }

        /// <summary>
        /// A mapping of plugin interface aliases to their backing integrations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interfaces")]
        public global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotPluginsInterfaces2>? Interfaces { get; set; }

        /// <summary>
        /// A mapping of plugin integration aliases to their backing integrations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotPluginsIntegrations2>? Integrations { get; set; }

        /// <summary>
        /// ID of the [Plugin](#schema_plugin)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation date of the [Plugin](#schema_plugin) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Updating date of the [Plugin](#schema_plugin) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Title of the plugin. This is the name that will be displayed in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Description of the plugin. This is the description that will be displayed in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// URL of the icon of the plugin. This is the icon that will be displayed in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iconUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IconUrl { get; set; }

        /// <summary>
        /// URL of the readme of the plugin. This is the readme that will be displayed in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readmeUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReadmeUrl { get; set; }

        /// <summary>
        /// [DEPRECATED] Indicates if the plugin is public. Please use the "visibility" parameter instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// The plugin's visibility. Public plugins are available to all and cannot be updated without creating a new version. Unlisted plugins behave identically to public plugins, but they are not listed in the plugin hub. By default, plugins are private and only accessible to the workspace that created them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminBotPluginsVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminBotPluginsVisibility Visibility { get; set; }

        /// <summary>
        /// The lifecycle status of the plugin. When a plugin is deprecated, it can no longer be installed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycleStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminBotPluginsLifecycleStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminBotPluginsLifecycleStatus LifecycleStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotPlugins2" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="name">
        /// Name of the [Plugin](#schema_plugin)
        /// </param>
        /// <param name="version">
        /// Version of the [Plugin](#schema_plugin)
        /// </param>
        /// <param name="configuration"></param>
        /// <param name="id">
        /// ID of the [Plugin](#schema_plugin)
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the [Plugin](#schema_plugin) in ISO 8601 format
        /// </param>
        /// <param name="updatedAt">
        /// Updating date of the [Plugin](#schema_plugin) in ISO 8601 format
        /// </param>
        /// <param name="title">
        /// Title of the plugin. This is the name that will be displayed in the UI
        /// </param>
        /// <param name="description">
        /// Description of the plugin. This is the description that will be displayed in the UI
        /// </param>
        /// <param name="iconUrl">
        /// URL of the icon of the plugin. This is the icon that will be displayed in the UI
        /// </param>
        /// <param name="readmeUrl">
        /// URL of the readme of the plugin. This is the readme that will be displayed in the UI
        /// </param>
        /// <param name="public">
        /// [DEPRECATED] Indicates if the plugin is public. Please use the "visibility" parameter instead.
        /// </param>
        /// <param name="visibility">
        /// The plugin's visibility. Public plugins are available to all and cannot be updated without creating a new version. Unlisted plugins behave identically to public plugins, but they are not listed in the plugin hub. By default, plugins are private and only accessible to the workspace that created them.
        /// </param>
        /// <param name="lifecycleStatus">
        /// The lifecycle status of the plugin. When a plugin is deprecated, it can no longer be installed.
        /// </param>
        /// <param name="interfaces">
        /// A mapping of plugin interface aliases to their backing integrations
        /// </param>
        /// <param name="integrations">
        /// A mapping of plugin integration aliases to their backing integrations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminBotPlugins2(
            bool enabled,
            string name,
            string version,
            object configuration,
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string title,
            string description,
            string iconUrl,
            string readmeUrl,
            bool @public,
            global::Botpress.AdminBotPluginsVisibility visibility,
            global::Botpress.AdminBotPluginsLifecycleStatus lifecycleStatus,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotPluginsInterfaces2>? interfaces,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotPluginsIntegrations2>? integrations)
        {
            this.Enabled = enabled;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Interfaces = interfaces;
            this.Integrations = integrations;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IconUrl = iconUrl ?? throw new global::System.ArgumentNullException(nameof(iconUrl));
            this.ReadmeUrl = readmeUrl ?? throw new global::System.ArgumentNullException(nameof(readmeUrl));
            this.Public = @public;
            this.Visibility = visibility;
            this.LifecycleStatus = lifecycleStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotPlugins2" /> class.
        /// </summary>
        public AdminBotPlugins2()
        {
        }
    }
}