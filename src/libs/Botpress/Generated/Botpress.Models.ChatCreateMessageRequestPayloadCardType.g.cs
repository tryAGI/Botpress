
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageRequestPayloadCardType
    {
        /// <summary>
        /// 
        /// </summary>
        Card,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageRequestPayloadCardTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageRequestPayloadCardType value)
        {
            return value switch
            {
                ChatCreateMessageRequestPayloadCardType.Card => "card",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageRequestPayloadCardType? ToEnum(string value)
        {
            return value switch
            {
                "card" => ChatCreateMessageRequestPayloadCardType.Card,
                _ => null,
            };
        }
    }
}