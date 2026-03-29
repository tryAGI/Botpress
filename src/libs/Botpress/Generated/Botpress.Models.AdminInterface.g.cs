
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminInterface
    {
        /// <summary>
        /// ID of the [Interface](#schema_interface)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation date of the [Interface](#schema_interface) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Updating date of the [Interface](#schema_interface) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Name of the [Interface](#schema_interface)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Version of the [Interface](#schema_interface)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceEntities2> Entities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceEvents2> Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceActions2> Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceChannels2> Channels { get; set; }

        /// <summary>
        /// Template string optionaly used at build time by integrations implementing this interface to pick a name for actions and events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nameTemplate")]
        public global::Botpress.AdminInterfaceNameTemplate? NameTemplate { get; set; }

        /// <summary>
        /// Optional attributes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attributes { get; set; }

        /// <summary>
        /// Title of the interface. This is the name that will be displayed in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Description of the interface. This is the description that will be displayed in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// URL of the icon of the interface. This is the icon that will be displayed in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iconUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IconUrl { get; set; }

        /// <summary>
        /// URL of the readme of the interface. This is the readme that will be displayed in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readmeUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReadmeUrl { get; set; }

        /// <summary>
        /// Indicates if the interface is public. Public interfaces are available to all and cannot be updated without creating a new version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminInterface" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the [Interface](#schema_interface)
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the [Interface](#schema_interface) in ISO 8601 format
        /// </param>
        /// <param name="updatedAt">
        /// Updating date of the [Interface](#schema_interface) in ISO 8601 format
        /// </param>
        /// <param name="name">
        /// Name of the [Interface](#schema_interface)
        /// </param>
        /// <param name="version">
        /// Version of the [Interface](#schema_interface)
        /// </param>
        /// <param name="entities"></param>
        /// <param name="events"></param>
        /// <param name="actions"></param>
        /// <param name="channels"></param>
        /// <param name="title">
        /// Title of the interface. This is the name that will be displayed in the UI
        /// </param>
        /// <param name="description">
        /// Description of the interface. This is the description that will be displayed in the UI
        /// </param>
        /// <param name="iconUrl">
        /// URL of the icon of the interface. This is the icon that will be displayed in the UI
        /// </param>
        /// <param name="readmeUrl">
        /// URL of the readme of the interface. This is the readme that will be displayed in the UI
        /// </param>
        /// <param name="public">
        /// Indicates if the interface is public. Public interfaces are available to all and cannot be updated without creating a new version.
        /// </param>
        /// <param name="nameTemplate">
        /// Template string optionaly used at build time by integrations implementing this interface to pick a name for actions and events.
        /// </param>
        /// <param name="attributes">
        /// Optional attributes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminInterface(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string name,
            string version,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceEntities2> entities,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceEvents2> events,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceActions2> actions,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceChannels2> channels,
            string title,
            string description,
            string iconUrl,
            string readmeUrl,
            bool @public,
            global::Botpress.AdminInterfaceNameTemplate? nameTemplate,
            global::System.Collections.Generic.Dictionary<string, string>? attributes)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
            this.Channels = channels ?? throw new global::System.ArgumentNullException(nameof(channels));
            this.NameTemplate = nameTemplate;
            this.Attributes = attributes;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IconUrl = iconUrl ?? throw new global::System.ArgumentNullException(nameof(iconUrl));
            this.ReadmeUrl = readmeUrl ?? throw new global::System.ArgumentNullException(nameof(readmeUrl));
            this.Public = @public;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminInterface" /> class.
        /// </summary>
        public AdminInterface()
        {
        }
    }
}