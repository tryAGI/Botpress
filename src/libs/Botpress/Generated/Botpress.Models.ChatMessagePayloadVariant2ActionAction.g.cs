
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatMessagePayloadVariant2ActionAction
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
    public static class ChatMessagePayloadVariant2ActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessagePayloadVariant2ActionAction value)
        {
            return value switch
            {
                ChatMessagePayloadVariant2ActionAction.Postback => "postback",
                ChatMessagePayloadVariant2ActionAction.Say => "say",
                ChatMessagePayloadVariant2ActionAction.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessagePayloadVariant2ActionAction? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatMessagePayloadVariant2ActionAction.Postback,
                "say" => ChatMessagePayloadVariant2ActionAction.Say,
                "url" => ChatMessagePayloadVariant2ActionAction.Url,
                _ => null,
            };
        }
    }
}