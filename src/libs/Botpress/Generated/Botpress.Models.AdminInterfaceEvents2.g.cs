
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Event Definition
    /// </summary>
    public sealed partial class AdminInterfaceEvents2
    {
        /// <summary>
        /// Title of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description of the event
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
        /// Initializes a new instance of the <see cref="AdminInterfaceEvents2" /> class.
        /// </summary>
        /// <param name="schema"></param>
        /// <param name="title">
        /// Title of the event
        /// </param>
        /// <param name="description">
        /// Description of the event
        /// </param>
        /// <param name="attributes">
        /// Optional attributes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminInterfaceEvents2(
            object schema,
            string? title,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? attributes)
        {
            this.Title = title;
            this.Description = description;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminInterfaceEvents2" /> class.
        /// </summary>
        public AdminInterfaceEvents2()
        {
        }
    }
}