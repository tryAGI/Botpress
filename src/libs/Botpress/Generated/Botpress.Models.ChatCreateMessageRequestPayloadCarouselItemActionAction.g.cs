
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageRequestPayloadCarouselItemActionAction
    {
        /// <summary>
        /// 
        /// </summary>
        Postback,
        /// <summary>
        /// 
        /// </summary>
        Say,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageRequestPayloadCarouselItemActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageRequestPayloadCarouselItemActionAction value)
        {
            return value switch
            {
                ChatCreateMessageRequestPayloadCarouselItemActionAction.Postback => "postback",
                ChatCreateMessageRequestPayloadCarouselItemActionAction.Say => "say",
                ChatCreateMessageRequestPayloadCarouselItemActionAction.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageRequestPayloadCarouselItemActionAction? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatCreateMessageRequestPayloadCarouselItemActionAction.Postback,
                "say" => ChatCreateMessageRequestPayloadCarouselItemActionAction.Say,
                "url" => ChatCreateMessageRequestPayloadCarouselItemActionAction.Url,
                _ => null,
            };
        }
    }
}