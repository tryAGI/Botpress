
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminPlugin
    {
        /// <summary>
        /// ID of the [Plugin](#schema_plugin)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        /// Configuration definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminPluginConfiguration Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("states")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginStates2> States { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginEvents2> Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginActions2> Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminPluginDependencies Dependencies { get; set; }

        /// <summary>
        /// User object configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminPluginUser User { get; set; }

        /// <summary>
        /// Conversation object configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminPluginConversation Conversation { get; set; }

        /// <summary>
        /// Message object configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminPluginMessage Message { get; set; }

        /// <summary>
        /// Optional attributes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attributes { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminPluginVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminPluginVisibility Visibility { get; set; }

        /// <summary>
        /// The lifecycle status of the plugin. When a plugin is deprecated, it can no longer be installed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycleStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminPluginLifecycleStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminPluginLifecycleStatus LifecycleStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminPlugin" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the [Plugin](#schema_plugin)
        /// </param>
        /// <param name="name">
        /// Name of the [Plugin](#schema_plugin)
        /// </param>
        /// <param name="version">
        /// Version of the [Plugin](#schema_plugin)
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the [Plugin](#schema_plugin) in ISO 8601 format
        /// </param>
        /// <param name="updatedAt">
        /// Updating date of the [Plugin](#schema_plugin) in ISO 8601 format
        /// </param>
        /// <param name="configuration">
        /// Configuration definition
        /// </param>
        /// <param name="states"></param>
        /// <param name="events"></param>
        /// <param name="actions"></param>
        /// <param name="dependencies"></param>
        /// <param name="user">
        /// User object configuration
        /// </param>
        /// <param name="conversation">
        /// Conversation object configuration
        /// </param>
        /// <param name="message">
        /// Message object configuration
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
        /// <param name="attributes">
        /// Optional attributes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminPlugin(
            string id,
            string name,
            string version,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Botpress.AdminPluginConfiguration configuration,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginStates2> states,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginEvents2> events,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginActions2> actions,
            global::Botpress.AdminPluginDependencies dependencies,
            global::Botpress.AdminPluginUser user,
            global::Botpress.AdminPluginConversation conversation,
            global::Botpress.AdminPluginMessage message,
            string title,
            string description,
            string iconUrl,
            string readmeUrl,
            bool @public,
            global::Botpress.AdminPluginVisibility visibility,
            global::Botpress.AdminPluginLifecycleStatus lifecycleStatus,
            global::System.Collections.Generic.Dictionary<string, string>? attributes)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.States = states ?? throw new global::System.ArgumentNullException(nameof(states));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
            this.Dependencies = dependencies ?? throw new global::System.ArgumentNullException(nameof(dependencies));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Conversation = conversation ?? throw new global::System.ArgumentNullException(nameof(conversation));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Attributes = attributes;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IconUrl = iconUrl ?? throw new global::System.ArgumentNullException(nameof(iconUrl));
            this.ReadmeUrl = readmeUrl ?? throw new global::System.ArgumentNullException(nameof(readmeUrl));
            this.Public = @public;
            this.Visibility = visibility;
            this.LifecycleStatus = lifecycleStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminPlugin" /> class.
        /// </summary>
        public AdminPlugin()
        {
        }
    }
}