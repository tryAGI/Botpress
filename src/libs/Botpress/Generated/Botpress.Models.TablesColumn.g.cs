
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TablesColumn
    {
        /// <summary>
        /// Unique identifier for the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the column, must be within length limits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional descriptive text about the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates if the column is vectorized and searchable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchable")]
        public bool? Searchable { get; set; }

        /// <summary>
        /// Specifies the data type of the column. Use "object" for complex data structures.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.TablesColumnTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.TablesColumnType Type { get; set; }

        /// <summary>
        /// TypeScript typings for the column. Recommended if the type is "object", ex: "\{ foo: string; bar: number \}"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typings")]
        public string? Typings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computed")]
        public global::Botpress.TablesColumnComputed? Computed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesColumn" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the column, must be within length limits.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of the column. Use "object" for complex data structures.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the column.
        /// </param>
        /// <param name="description">
        /// Optional descriptive text about the column.
        /// </param>
        /// <param name="searchable">
        /// Indicates if the column is vectorized and searchable.
        /// </param>
        /// <param name="typings">
        /// TypeScript typings for the column. Recommended if the type is "object", ex: "\{ foo: string; bar: number \}"
        /// </param>
        /// <param name="computed"></param>
        /// <param name="schema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TablesColumn(
            string name,
            global::Botpress.TablesColumnType type,
            string? id,
            string? description,
            bool? searchable,
            string? typings,
            global::Botpress.TablesColumnComputed? computed,
            object? schema)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Searchable = searchable;
            this.Type = type;
            this.Typings = typings;
            this.Computed = computed;
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesColumn" /> class.
        /// </summary>
        public TablesColumn()
        {
        }
    }
}