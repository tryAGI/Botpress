
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum TablesTableSchemaPropertiesItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        Array,
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Null,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Object,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TablesTableSchemaPropertiesItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TablesTableSchemaPropertiesItemsType value)
        {
            return value switch
            {
                TablesTableSchemaPropertiesItemsType.Array => "array",
                TablesTableSchemaPropertiesItemsType.Boolean => "boolean",
                TablesTableSchemaPropertiesItemsType.Null => "null",
                TablesTableSchemaPropertiesItemsType.Number => "number",
                TablesTableSchemaPropertiesItemsType.Object => "object",
                TablesTableSchemaPropertiesItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TablesTableSchemaPropertiesItemsType? ToEnum(string value)
        {
            return value switch
            {
                "array" => TablesTableSchemaPropertiesItemsType.Array,
                "boolean" => TablesTableSchemaPropertiesItemsType.Boolean,
                "null" => TablesTableSchemaPropertiesItemsType.Null,
                "number" => TablesTableSchemaPropertiesItemsType.Number,
                "object" => TablesTableSchemaPropertiesItemsType.Object,
                "string" => TablesTableSchemaPropertiesItemsType.String,
                _ => null,
            };
        }
    }
}