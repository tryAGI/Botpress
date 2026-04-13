
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageRequestPayloadCarouselType
    {
        /// <summary>
        /// 
        /// </summary>
        Carousel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageRequestPayloadCarouselTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageRequestPayloadCarouselType value)
        {
            return value switch
            {
                ChatCreateMessageRequestPayloadCarouselType.Carousel => "carousel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageRequestPayloadCarouselType? ToEnum(string value)
        {
            return value switch
            {
                "carousel" => ChatCreateMessageRequestPayloadCarouselType.Carousel,
                _ => null,
            };
        }
    }
}