
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum TablesTableSchemaPropertiesPropertiesType
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
    public static class TablesTableSchemaPropertiesPropertiesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TablesTableSchemaPropertiesPropertiesType value)
        {
            return value switch
            {
                TablesTableSchemaPropertiesPropertiesType.Array => "array",
                TablesTableSchemaPropertiesPropertiesType.Boolean => "boolean",
                TablesTableSchemaPropertiesPropertiesType.Null => "null",
                TablesTableSchemaPropertiesPropertiesType.Number => "number",
                TablesTableSchemaPropertiesPropertiesType.Object => "object",
                TablesTableSchemaPropertiesPropertiesType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TablesTableSchemaPropertiesPropertiesType? ToEnum(string value)
        {
            return value switch
            {
                "array" => TablesTableSchemaPropertiesPropertiesType.Array,
                "boolean" => TablesTableSchemaPropertiesPropertiesType.Boolean,
                "null" => TablesTableSchemaPropertiesPropertiesType.Null,
                "number" => TablesTableSchemaPropertiesPropertiesType.Number,
                "object" => TablesTableSchemaPropertiesPropertiesType.Object,
                "string" => TablesTableSchemaPropertiesPropertiesType.String,
                _ => null,
            };
        }
    }
}