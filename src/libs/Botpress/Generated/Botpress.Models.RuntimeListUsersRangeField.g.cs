
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuntimeListUsersRangeField
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
    public static class RuntimeListUsersRangeFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeListUsersRangeField value)
        {
            return value switch
            {
                RuntimeListUsersRangeField.CreatedAt => "createdAt",
                RuntimeListUsersRangeField.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeListUsersRangeField? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => RuntimeListUsersRangeField.CreatedAt,
                "updatedAt" => RuntimeListUsersRangeField.UpdatedAt,
                _ => null,
            };
        }
    }
}