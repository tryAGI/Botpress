
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatGetMessageResponseMessagePayloadVariant2ActionAction2
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
    public static class ChatGetMessageResponseMessagePayloadVariant2ActionAction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatGetMessageResponseMessagePayloadVariant2ActionAction2 value)
        {
            return value switch
            {
                ChatGetMessageResponseMessagePayloadVariant2ActionAction2.Postback => "postback",
                ChatGetMessageResponseMessagePayloadVariant2ActionAction2.Say => "say",
                ChatGetMessageResponseMessagePayloadVariant2ActionAction2.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatGetMessageResponseMessagePayloadVariant2ActionAction2? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatGetMessageResponseMessagePayloadVariant2ActionAction2.Postback,
                "say" => ChatGetMessageResponseMessagePayloadVariant2ActionAction2.Say,
                "url" => ChatGetMessageResponseMessagePayloadVariant2ActionAction2.Url,
                _ => null,
            };
        }
    }
}