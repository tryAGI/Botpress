
#nullable enable

namespace Botpress
{
    /// <summary>
    /// The user creation setting determines how to create a user through the API directly. The integration will have to implement the `createUser` functionality to support this setting.
    /// </summary>
    public sealed partial class AdminIntegrationUserCreation
    {
        /// <summary>
        /// Enable user creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// The list of tags that are required to be specified when calling the API directly to create a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requiredTags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RequiredTags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationUserCreation" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Enable user creation
        /// </param>
        /// <param name="requiredTags">
        /// The list of tags that are required to be specified when calling the API directly to create a user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminIntegrationUserCreation(
            bool enabled,
            global::System.Collections.Generic.IList<string> requiredTags)
        {
            this.Enabled = enabled;
            this.RequiredTags = requiredTags ?? throw new global::System.ArgumentNullException(nameof(requiredTags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationUserCreation" /> class.
        /// </summary>
        public AdminIntegrationUserCreation()
        {
        }
    }
}