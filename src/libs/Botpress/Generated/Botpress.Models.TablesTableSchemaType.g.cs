
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum TablesTableSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TablesTableSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TablesTableSchemaType value)
        {
            return value switch
            {
                TablesTableSchemaType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TablesTableSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "object" => TablesTableSchemaType.Object,
                _ => null,
            };
        }
    }
}