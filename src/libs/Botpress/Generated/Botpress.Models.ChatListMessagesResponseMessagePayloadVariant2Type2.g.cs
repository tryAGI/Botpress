
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatListMessagesResponseMessagePayloadVariant2Type2
    {
        /// <summary>
        /// 
        /// </summary>
        Card,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatListMessagesResponseMessagePayloadVariant2Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatListMessagesResponseMessagePayloadVariant2Type2 value)
        {
            return value switch
            {
                ChatListMessagesResponseMessagePayloadVariant2Type2.Card => "card",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatListMessagesResponseMessagePayloadVariant2Type2? ToEnum(string value)
        {
            return value switch
            {
                "card" => ChatListMessagesResponseMessagePayloadVariant2Type2.Card,
                _ => null,
            };
        }
    }
}