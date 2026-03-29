
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TablesTable
    {
        /// <summary>
        /// Unique identifier for the table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Required. This name is used to identify your table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The 'factor' multiplies the row's data storage limit by 4KB and its quota count. It can only be increased (not decreased) after table creation via updateTable. For instance, a factor of 2 increases storage to 8KB but counts as 2 rows in your quota. The default factor is 1.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("factor")]
        public double? Factor { get; set; }

        /// <summary>
        /// A table designated as "frozen" is immutable in terms of its name and schema structure; modifications to its schema or a renaming operation are not permitted. The only action that can be taken on such a table is deletion. The schema established at the time of creation is locked in as the final structure. To implement any changes, the table must be duplicated with the desired alterations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frozen")]
        public bool? Frozen { get; set; }

        /// <summary>
        /// Designate a column as the primary unique identifier for this table. When set, a unique index is automatically created on this column, enabling significantly faster upsert operations. All values in this column must be unique across the table. When set to null, the key index is removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyColumn")]
        public string? KeyColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.TablesTableSchema Schema { get; set; }

        /// <summary>
        /// Optional tags to help organize your tables. These should be passed here as an object representing key/value pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// Indicates if the table is enabled for computation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isComputeEnabled")]
        public bool? IsComputeEnabled { get; set; }

        /// <summary>
        /// Timestamp of table creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of the last table update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesTable" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the table
        /// </param>
        /// <param name="name">
        /// Required. This name is used to identify your table.
        /// </param>
        /// <param name="schema"></param>
        /// <param name="factor">
        /// The 'factor' multiplies the row's data storage limit by 4KB and its quota count. It can only be increased (not decreased) after table creation via updateTable. For instance, a factor of 2 increases storage to 8KB but counts as 2 rows in your quota. The default factor is 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="frozen">
        /// A table designated as "frozen" is immutable in terms of its name and schema structure; modifications to its schema or a renaming operation are not permitted. The only action that can be taken on such a table is deletion. The schema established at the time of creation is locked in as the final structure. To implement any changes, the table must be duplicated with the desired alterations.
        /// </param>
        /// <param name="keyColumn">
        /// Designate a column as the primary unique identifier for this table. When set, a unique index is automatically created on this column, enabling significantly faster upsert operations. All values in this column must be unique across the table. When set to null, the key index is removed.
        /// </param>
        /// <param name="tags">
        /// Optional tags to help organize your tables. These should be passed here as an object representing key/value pairs.
        /// </param>
        /// <param name="isComputeEnabled">
        /// Indicates if the table is enabled for computation.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of table creation.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of the last table update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TablesTable(
            string id,
            string name,
            global::Botpress.TablesTableSchema schema,
            double? factor,
            bool? frozen,
            string? keyColumn,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            bool? isComputeEnabled,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Factor = factor;
            this.Frozen = frozen;
            this.KeyColumn = keyColumn;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Tags = tags;
            this.IsComputeEnabled = isComputeEnabled;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesTable" /> class.
        /// </summary>
        public TablesTable()
        {
        }
    }
}