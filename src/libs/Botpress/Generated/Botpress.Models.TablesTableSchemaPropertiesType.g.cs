
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum TablesTableSchemaPropertiesType
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
    public static class TablesTableSchemaPropertiesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TablesTableSchemaPropertiesType value)
        {
            return value switch
            {
                TablesTableSchemaPropertiesType.Array => "array",
                TablesTableSchemaPropertiesType.Boolean => "boolean",
                TablesTableSchemaPropertiesType.Null => "null",
                TablesTableSchemaPropertiesType.Number => "number",
                TablesTableSchemaPropertiesType.Object => "object",
                TablesTableSchemaPropertiesType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TablesTableSchemaPropertiesType? ToEnum(string value)
        {
            return value switch
            {
                "array" => TablesTableSchemaPropertiesType.Array,
                "boolean" => TablesTableSchemaPropertiesType.Boolean,
                "null" => TablesTableSchemaPropertiesType.Null,
                "number" => TablesTableSchemaPropertiesType.Number,
                "object" => TablesTableSchemaPropertiesType.Object,
                "string" => TablesTableSchemaPropertiesType.String,
                _ => null,
            };
        }
    }
}