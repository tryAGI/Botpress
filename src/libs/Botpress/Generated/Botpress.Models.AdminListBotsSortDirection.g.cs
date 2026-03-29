
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdminListBotsSortDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminListBotsSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminListBotsSortDirection value)
        {
            return value switch
            {
                AdminListBotsSortDirection.Asc => "asc",
                AdminListBotsSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminListBotsSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AdminListBotsSortDirection.Asc,
                "desc" => AdminListBotsSortDirection.Desc,
                _ => null,
            };
        }
    }
}