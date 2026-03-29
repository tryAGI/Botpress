
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Entity definition
    /// </summary>
    public sealed partial class AdminIntegrationEntities2
    {
        /// <summary>
        /// Title of the entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description of the entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationEntities2" /> class.
        /// </summary>
        /// <param name="schema"></param>
        /// <param name="title">
        /// Title of the entity
        /// </param>
        /// <param name="description">
        /// Description of the entity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminIntegrationEntities2(
            object schema,
            string? title,
            string? description)
        {
            this.Title = title;
            this.Description = description;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationEntities2" /> class.
        /// </summary>
        public AdminIntegrationEntities2()
        {
        }
    }
}