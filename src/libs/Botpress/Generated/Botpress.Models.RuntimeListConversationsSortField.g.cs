
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuntimeListConversationsSortField
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
    public static class RuntimeListConversationsSortFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeListConversationsSortField value)
        {
            return value switch
            {
                RuntimeListConversationsSortField.CreatedAt => "createdAt",
                RuntimeListConversationsSortField.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeListConversationsSortField? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => RuntimeListConversationsSortField.CreatedAt,
                "updatedAt" => RuntimeListConversationsSortField.UpdatedAt,
                _ => null,
            };
        }
    }
}