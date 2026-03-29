
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuntimeListConversationsSortDirection
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
    public static class RuntimeListConversationsSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeListConversationsSortDirection value)
        {
            return value switch
            {
                RuntimeListConversationsSortDirection.Asc => "asc",
                RuntimeListConversationsSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeListConversationsSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => RuntimeListConversationsSortDirection.Asc,
                "desc" => RuntimeListConversationsSortDirection.Desc,
                _ => null,
            };
        }
    }
}