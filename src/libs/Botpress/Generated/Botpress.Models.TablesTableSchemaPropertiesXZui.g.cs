
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TablesTableSchemaPropertiesXZui
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// [deprecated] ID of the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Indicates if the column is vectorized and searchable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchable")]
        public bool? Searchable { get; set; }

        /// <summary>
        /// Indicates if the field is hidden in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Order of the column in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public double? Order { get; set; }

        /// <summary>
        /// Width of the column in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// ID of the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemaId")]
        public string? SchemaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computed")]
        public global::Botpress.TablesTableSchemaPropertiesXZuiComputed? Computed { get; set; }

        /// <summary>
        /// TypeScript typings for the column. Recommended if the type is "object", ex: "\{ foo: string; bar: number \}"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typings")]
        public string? Typings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesTableSchemaPropertiesXZui" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="id">
        /// [deprecated] ID of the column.
        /// </param>
        /// <param name="searchable">
        /// Indicates if the column is vectorized and searchable.
        /// </param>
        /// <param name="hidden">
        /// Indicates if the field is hidden in the UI
        /// </param>
        /// <param name="order">
        /// Order of the column in the UI
        /// </param>
        /// <param name="width">
        /// Width of the column in the UI
        /// </param>
        /// <param name="schemaId">
        /// ID of the schema
        /// </param>
        /// <param name="computed"></param>
        /// <param name="typings">
        /// TypeScript typings for the column. Recommended if the type is "object", ex: "\{ foo: string; bar: number \}"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TablesTableSchemaPropertiesXZui(
            int index,
            string? id,
            bool? searchable,
            bool? hidden,
            double? order,
            double? width,
            string? schemaId,
            global::Botpress.TablesTableSchemaPropertiesXZuiComputed? computed,
            string? typings)
        {
            this.Index = index;
            this.Id = id;
            this.Searchable = searchable;
            this.Hidden = hidden;
            this.Order = order;
            this.Width = width;
            this.SchemaId = schemaId;
            this.Computed = computed;
            this.Typings = typings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesTableSchemaPropertiesXZui" /> class.
        /// </summary>
        public TablesTableSchemaPropertiesXZui()
        {
        }
    }
}