
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatGetOrCreateUserRequest
    {
        /// <summary>
        /// Name of the [User](#schema_user) (not a unique identifier)
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetOrCreateUserRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the [User](#schema_user) (not a unique identifier)
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
        public ChatGetOrCreateUserRequest(
            string? name,
            string? pictureUrl,
            string? profile)
        {
            this.Name = name;
            this.PictureUrl = pictureUrl;
            this.Profile = profile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGetOrCreateUserRequest" /> class.
        /// </summary>
        public ChatGetOrCreateUserRequest()
        {
        }
    }
}