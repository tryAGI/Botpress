
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum TablesTableSchemaPropertiesFormat
    {
        /// <summary>
        /// 
        /// </summary>
        DateTime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TablesTableSchemaPropertiesFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TablesTableSchemaPropertiesFormat value)
        {
            return value switch
            {
                TablesTableSchemaPropertiesFormat.DateTime => "date-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TablesTableSchemaPropertiesFormat? ToEnum(string value)
        {
            return value switch
            {
                "date-time" => TablesTableSchemaPropertiesFormat.DateTime,
                _ => null,
            };
        }
    }
}