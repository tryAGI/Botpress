
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Specifies the data type of the column. Use "object" for complex data structures.
    /// </summary>
    public enum TablesColumnType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Date,
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
    public static class TablesColumnTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TablesColumnType value)
        {
            return value switch
            {
                TablesColumnType.Boolean => "boolean",
                TablesColumnType.Date => "date",
                TablesColumnType.Number => "number",
                TablesColumnType.Object => "object",
                TablesColumnType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TablesColumnType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => TablesColumnType.Boolean,
                "date" => TablesColumnType.Date,
                "number" => TablesColumnType.Number,
                "object" => TablesColumnType.Object,
                "string" => TablesColumnType.String,
                _ => null,
            };
        }
    }
}