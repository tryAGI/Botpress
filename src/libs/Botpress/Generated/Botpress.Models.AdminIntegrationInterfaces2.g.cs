
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminIntegrationInterfaces2
    {
        /// <summary>
        /// ID of the interface
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the interface
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Version of the interface
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfacesEntities2> Entities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfacesActions2> Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfacesEvents2> Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfacesChannels2> Channels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationInterfaces2" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the interface
        /// </param>
        /// <param name="name">
        /// Name of the interface
        /// </param>
        /// <param name="version">
        /// Version of the interface
        /// </param>
        /// <param name="entities"></param>
        /// <param name="actions"></param>
        /// <param name="events"></param>
        /// <param name="channels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminIntegrationInterfaces2(
            string id,
            string name,
            string version,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfacesEntities2> entities,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfacesActions2> actions,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfacesEvents2> events,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfacesChannels2> channels)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Channels = channels ?? throw new global::System.ArgumentNullException(nameof(channels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationInterfaces2" /> class.
        /// </summary>
        public AdminIntegrationInterfaces2()
        {
        }
    }
}