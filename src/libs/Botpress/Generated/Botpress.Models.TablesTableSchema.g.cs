
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TablesTableSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$schema")]
        public string? x_schema { get; set; }

        /// <summary>
        /// List of keys/columns in the table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.TablesTableSchemaProperties2> Properties { get; set; }

        /// <summary>
        /// Additional properties can be provided, but they will be ignored if no column matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalProperties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AdditionalProperties { get; set; }

        /// <summary>
        /// Array of required properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.TablesTableSchemaTypeJsonConverter))]
        public global::Botpress.TablesTableSchemaType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties2 { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesTableSchema" /> class.
        /// </summary>
        /// <param name="properties">
        /// List of keys/columns in the table.
        /// </param>
        /// <param name="additionalProperties">
        /// Additional properties can be provided, but they will be ignored if no column matches.
        /// </param>
        /// <param name="x_schema"></param>
        /// <param name="required">
        /// Array of required properties.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TablesTableSchema(
            global::System.Collections.Generic.Dictionary<string, global::Botpress.TablesTableSchemaProperties2> properties,
            bool additionalProperties,
            string? x_schema,
            global::System.Collections.Generic.IList<string>? required,
            global::Botpress.TablesTableSchemaType type)
        {
            this.x_schema = x_schema;
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.AdditionalProperties = additionalProperties;
            this.Required = required;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesTableSchema" /> class.
        /// </summary>
        public TablesTableSchema()
        {
        }
    }
}