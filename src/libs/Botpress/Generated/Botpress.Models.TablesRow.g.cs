
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TablesRow
    {
        /// <summary>
        /// Unique identifier for the row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Id { get; set; }

        /// <summary>
        /// Timestamp of row creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of the last row update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.TablesRowComputed2> Computed { get; set; }

        /// <summary>
        /// [Read-only] List of stale values that are waiting to be recomputed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stale")]
        public global::System.Collections.Generic.IList<string>? Stale { get; set; }

        /// <summary>
        /// Optional numeric value indicating similarity, when using findTableRows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity")]
        public double? Similarity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesRow" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the row.
        /// </param>
        /// <param name="computed"></param>
        /// <param name="createdAt">
        /// Timestamp of row creation.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of the last row update.
        /// </param>
        /// <param name="stale">
        /// [Read-only] List of stale values that are waiting to be recomputed.
        /// </param>
        /// <param name="similarity">
        /// Optional numeric value indicating similarity, when using findTableRows.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TablesRow(
            double id,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.TablesRowComputed2> computed,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<string>? stale,
            double? similarity)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Computed = computed ?? throw new global::System.ArgumentNullException(nameof(computed));
            this.Stale = stale;
            this.Similarity = similarity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesRow" /> class.
        /// </summary>
        public TablesRow()
        {
        }
    }
}