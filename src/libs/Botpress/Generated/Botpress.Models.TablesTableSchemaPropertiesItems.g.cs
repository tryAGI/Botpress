
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Defines the shape of items in an array
    /// </summary>
    public sealed partial class TablesTableSchemaPropertiesItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.TablesTableSchemaPropertiesItemsTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.TablesTableSchemaPropertiesItemsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesTableSchemaPropertiesItems" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TablesTableSchemaPropertiesItems(
            global::Botpress.TablesTableSchemaPropertiesItemsType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesTableSchemaPropertiesItems" /> class.
        /// </summary>
        public TablesTableSchemaPropertiesItems()
        {
        }
    }
}