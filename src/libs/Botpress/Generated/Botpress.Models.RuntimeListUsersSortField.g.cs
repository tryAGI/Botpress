
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuntimeListUsersSortField
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
    public static class RuntimeListUsersSortFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeListUsersSortField value)
        {
            return value switch
            {
                RuntimeListUsersSortField.CreatedAt => "createdAt",
                RuntimeListUsersSortField.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeListUsersSortField? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => RuntimeListUsersSortField.CreatedAt,
                "updatedAt" => RuntimeListUsersSortField.UpdatedAt,
                _ => null,
            };
        }
    }
}