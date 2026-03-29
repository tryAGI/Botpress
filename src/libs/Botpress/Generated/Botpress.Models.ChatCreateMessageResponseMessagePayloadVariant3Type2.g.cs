
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageResponseMessagePayloadVariant3Type2
    {
        /// <summary>
        /// 
        /// </summary>
        Carousel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageResponseMessagePayloadVariant3Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageResponseMessagePayloadVariant3Type2 value)
        {
            return value switch
            {
                ChatCreateMessageResponseMessagePayloadVariant3Type2.Carousel => "carousel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageResponseMessagePayloadVariant3Type2? ToEnum(string value)
        {
            return value switch
            {
                "carousel" => ChatCreateMessageResponseMessagePayloadVariant3Type2.Carousel,
                _ => null,
            };
        }
    }
}