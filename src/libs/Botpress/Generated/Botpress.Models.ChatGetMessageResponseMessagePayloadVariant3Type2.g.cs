
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatGetMessageResponseMessagePayloadVariant3Type2
    {
        /// <summary>
        /// 
        /// </summary>
        Carousel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatGetMessageResponseMessagePayloadVariant3Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatGetMessageResponseMessagePayloadVariant3Type2 value)
        {
            return value switch
            {
                ChatGetMessageResponseMessagePayloadVariant3Type2.Carousel => "carousel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatGetMessageResponseMessagePayloadVariant3Type2? ToEnum(string value)
        {
            return value switch
            {
                "carousel" => ChatGetMessageResponseMessagePayloadVariant3Type2.Carousel,
                _ => null,
            };
        }
    }
}