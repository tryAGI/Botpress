
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatGetMessageResponseMessagePayloadVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Carousel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatGetMessageResponseMessagePayloadVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatGetMessageResponseMessagePayloadVariant3Type value)
        {
            return value switch
            {
                ChatGetMessageResponseMessagePayloadVariant3Type.Carousel => "carousel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatGetMessageResponseMessagePayloadVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "carousel" => ChatGetMessageResponseMessagePayloadVariant3Type.Carousel,
                _ => null,
            };
        }
    }
}