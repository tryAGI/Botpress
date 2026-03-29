
#nullable enable

namespace Botpress
{
    /// <summary>
    /// The user object represents someone interacting with the bot within a specific integration. The same person interacting with a bot in slack and messenger will be represented with two different users.
    /// </summary>
    public sealed partial class ChatGetOrCreateUserResponseUser2
    {
        /// <summary>
        /// Identifier of the [User](#schema_user)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the [User](#schema_user)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Picture url of the [User](#schema_user)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// Custom profile data of the [User](#schema_user) encoded as a string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        public string? Profile { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetOrCreateUserResponseUser2" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the [User](#schema_user)
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the [User](#schema_user) in ISO 8601 format
        /// </param>
        /// <param name="updatedAt">
        /// Updating date of the [User](#schema_user) in ISO 8601 format
        /// </param>
        /// <param name="name">
        /// Name of the [User](#schema_user)
        /// </param>
        /// <param name="pictureUrl">
        /// Picture url of the [User](#schema_user)
        /// </param>
        /// <param name="profile">
        /// Custom profile data of the [User](#schema_user) encoded as a string
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatGetOrCreateUserResponseUser2(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? name,
            string? pictureUrl,
            string? profile)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.PictureUrl = pictureUrl;
            this.Profile = profile;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetOrCreateUserResponseUser2" /> class.
        /// </summary>
        public ChatGetOrCreateUserResponseUser2()
        {
        }
    }
}