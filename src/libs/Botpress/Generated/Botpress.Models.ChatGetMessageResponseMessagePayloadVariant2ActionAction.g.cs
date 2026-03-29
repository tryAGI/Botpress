
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatGetMessageResponseMessagePayloadVariant2ActionAction
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
    public static class ChatGetMessageResponseMessagePayloadVariant2ActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatGetMessageResponseMessagePayloadVariant2ActionAction value)
        {
            return value switch
            {
                ChatGetMessageResponseMessagePayloadVariant2ActionAction.Postback => "postback",
                ChatGetMessageResponseMessagePayloadVariant2ActionAction.Say => "say",
                ChatGetMessageResponseMessagePayloadVariant2ActionAction.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatGetMessageResponseMessagePayloadVariant2ActionAction? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatGetMessageResponseMessagePayloadVariant2ActionAction.Postback,
                "say" => ChatGetMessageResponseMessagePayloadVariant2ActionAction.Say,
                "url" => ChatGetMessageResponseMessagePayloadVariant2ActionAction.Url,
                _ => null,
            };
        }
    }
}