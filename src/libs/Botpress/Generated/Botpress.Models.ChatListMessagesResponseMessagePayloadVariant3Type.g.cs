
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatListMessagesResponseMessagePayloadVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Carousel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatListMessagesResponseMessagePayloadVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatListMessagesResponseMessagePayloadVariant3Type value)
        {
            return value switch
            {
                ChatListMessagesResponseMessagePayloadVariant3Type.Carousel => "carousel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatListMessagesResponseMessagePayloadVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "carousel" => ChatListMessagesResponseMessagePayloadVariant3Type.Carousel,
                _ => null,
            };
        }
    }
}