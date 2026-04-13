
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageRequestPayloadChoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Choice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageRequestPayloadChoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageRequestPayloadChoiceType value)
        {
            return value switch
            {
                ChatCreateMessageRequestPayloadChoiceType.Choice => "choice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageRequestPayloadChoiceType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => ChatCreateMessageRequestPayloadChoiceType.Choice,
                _ => null,
            };
        }
    }
}