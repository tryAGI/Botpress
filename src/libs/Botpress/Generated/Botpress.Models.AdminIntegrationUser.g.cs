
#nullable enable

namespace Botpress
{
    /// <summary>
    /// User object configuration
    /// </summary>
    public sealed partial class AdminIntegrationUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationUserTags2> Tags { get; set; }

        /// <summary>
        /// The user creation setting determines how to create a user through the API directly. The integration will have to implement the `createUser` functionality to support this setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminIntegrationUserCreation Creation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationUser" /> class.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="creation">
        /// The user creation setting determines how to create a user through the API directly. The integration will have to implement the `createUser` functionality to support this setting.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminIntegrationUser(
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationUserTags2> tags,
            global::Botpress.AdminIntegrationUserCreation creation)
        {
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Creation = creation ?? throw new global::System.ArgumentNullException(nameof(creation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationUser" /> class.
        /// </summary>
        public AdminIntegrationUser()
        {
        }
    }
}