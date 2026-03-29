
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Definition of a tag that can be provided on the object
    /// </summary>
    public sealed partial class AdminBotConversationTags2
    {
        /// <summary>
        /// Title of the tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description of the tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotConversationTags2" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the tag
        /// </param>
        /// <param name="description">
        /// Description of the tag
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminBotConversationTags2(
            string? title,
            string? description)
        {
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotConversationTags2" /> class.
        /// </summary>
        public AdminBotConversationTags2()
        {
        }
    }
}