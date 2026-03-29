
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TablesTableSchemaProperties2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.TablesTableSchemaPropertiesTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.TablesTableSchemaPropertiesType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.TablesTableSchemaPropertiesFormatJsonConverter))]
        public global::Botpress.TablesTableSchemaPropertiesFormat? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// String properties must match this pattern
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// String properties must be one of these values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// Defines the shape of items in an array
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::Botpress.TablesTableSchemaPropertiesItems? Items { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nullable")]
        public bool? Nullable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::Botpress.TablesTableSchemaPropertiesProperties2>? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x-zui")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.TablesTableSchemaPropertiesXZui XZui { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesTableSchemaProperties2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="xZui"></param>
        /// <param name="format"></param>
        /// <param name="description"></param>
        /// <param name="pattern">
        /// String properties must match this pattern
        /// </param>
        /// <param name="enum">
        /// String properties must be one of these values
        /// </param>
        /// <param name="items">
        /// Defines the shape of items in an array
        /// </param>
        /// <param name="nullable">
        /// Default Value: true
        /// </param>
        /// <param name="properties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TablesTableSchemaProperties2(
            global::Botpress.TablesTableSchemaPropertiesType type,
            global::Botpress.TablesTableSchemaPropertiesXZui xZui,
            global::Botpress.TablesTableSchemaPropertiesFormat? format,
            string? description,
            string? pattern,
            global::System.Collections.Generic.IList<string>? @enum,
            global::Botpress.TablesTableSchemaPropertiesItems? items,
            bool? nullable,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.TablesTableSchemaPropertiesProperties2>? properties)
        {
            this.Type = type;
            this.Format = format;
            this.Description = description;
            this.Pattern = pattern;
            this.Enum = @enum;
            this.Items = items;
            this.Nullable = nullable;
            this.Properties = properties;
            this.XZui = xZui ?? throw new global::System.ArgumentNullException(nameof(xZui));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesTableSchemaProperties2" /> class.
        /// </summary>
        public TablesTableSchemaProperties2()
        {
        }
    }
}