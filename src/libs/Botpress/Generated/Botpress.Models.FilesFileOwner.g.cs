
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilesFileOwner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.FilesFileOwnerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.FilesFileOwnerType Type { get; set; }

        /// <summary>
        /// This field is present if `type` is "user" or "bot". If `type` is "user", this is the user ID. If `type` is "bot", this is the bot ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// This field is present if the `type` is "integration". If `type` is "integration", this is the integration name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This field is present if the `type` is "integration". If `type` is "integration", this is the integration instance alias.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFileOwner" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id">
        /// This field is present if `type` is "user" or "bot". If `type` is "user", this is the user ID. If `type` is "bot", this is the bot ID.
        /// </param>
        /// <param name="name">
        /// This field is present if the `type` is "integration". If `type` is "integration", this is the integration name.
        /// </param>
        /// <param name="alias">
        /// This field is present if the `type` is "integration". If `type` is "integration", this is the integration instance alias.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilesFileOwner(
            global::Botpress.FilesFileOwnerType type,
            string? id,
            string? name,
            string? alias)
        {
            this.Type = type;
            this.Id = id;
            this.Name = name;
            this.Alias = alias;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFileOwner" /> class.
        /// </summary>
        public FilesFileOwner()
        {
        }
    }
}