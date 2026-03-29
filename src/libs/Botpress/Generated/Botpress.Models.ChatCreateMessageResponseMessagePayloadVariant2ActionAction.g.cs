
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageResponseMessagePayloadVariant2ActionAction
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
    public static class ChatCreateMessageResponseMessagePayloadVariant2ActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageResponseMessagePayloadVariant2ActionAction value)
        {
            return value switch
            {
                ChatCreateMessageResponseMessagePayloadVariant2ActionAction.Postback => "postback",
                ChatCreateMessageResponseMessagePayloadVariant2ActionAction.Say => "say",
                ChatCreateMessageResponseMessagePayloadVariant2ActionAction.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageResponseMessagePayloadVariant2ActionAction? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatCreateMessageResponseMessagePayloadVariant2ActionAction.Postback,
                "say" => ChatCreateMessageResponseMessagePayloadVariant2ActionAction.Say,
                "url" => ChatCreateMessageResponseMessagePayloadVariant2ActionAction.Url,
                _ => null,
            };
        }
    }
}