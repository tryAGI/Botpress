
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdminListBotsSortField
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminListBotsSortFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminListBotsSortField value)
        {
            return value switch
            {
                AdminListBotsSortField.CreatedAt => "createdAt",
                AdminListBotsSortField.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminListBotsSortField? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => AdminListBotsSortField.CreatedAt,
                "updatedAt" => AdminListBotsSortField.UpdatedAt,
                _ => null,
            };
        }
    }
}