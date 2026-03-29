
#nullable enable

namespace Botpress
{
    /// <summary>
    /// The user object represents someone interacting with the bot within a specific integration. The same person interacting with a bot in slack and messenger will be represented with two different users.
    /// </summary>
    public sealed partial class RuntimeUser
    {
        /// <summary>
        /// Id of the [User](#schema_user)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation date of the [User](#schema_user) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Updating date of the [User](#schema_user) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Set of [Tags](/docs/developers/concepts/tags) that you can attach to a [User](#schema_user). The set of [Tags](/docs/developers/concepts/tags) available on a [User](#schema_user) is restricted by the list of [Tags](/docs/developers/concepts/tags) defined previously by the [Bot](#schema_bot). Individual keys can be unset by posting an empty value to them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Name of the [User](#schema_user)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Picture URL of the [User](#schema_user)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// Optional properties
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, string>? Properties { get; set; }

        /// <summary>
        /// Optional attributes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeUser" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the [User](#schema_user)
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the [User](#schema_user) in ISO 8601 format
        /// </param>
        /// <param name="updatedAt">
        /// Updating date of the [User](#schema_user) in ISO 8601 format
        /// </param>
        /// <param name="tags">
        /// Set of [Tags](/docs/developers/concepts/tags) that you can attach to a [User](#schema_user). The set of [Tags](/docs/developers/concepts/tags) available on a [User](#schema_user) is restricted by the list of [Tags](/docs/developers/concepts/tags) defined previously by the [Bot](#schema_bot). Individual keys can be unset by posting an empty value to them.
        /// </param>
        /// <param name="name">
        /// Name of the [User](#schema_user)
        /// </param>
        /// <param name="pictureUrl">
        /// Picture URL of the [User](#schema_user)
        /// </param>
        /// <param name="properties">
        /// Optional properties
        /// </param>
        /// <param name="attributes">
        /// Optional attributes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuntimeUser(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.Dictionary<string, string> tags,
            string? name,
            string? pictureUrl,
            global::System.Collections.Generic.Dictionary<string, string>? properties,
            global::System.Collections.Generic.Dictionary<string, string>? attributes)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Name = name;
            this.PictureUrl = pictureUrl;
            this.Properties = properties;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeUser" /> class.
        /// </summary>
        public RuntimeUser()
        {
        }
    }
}