
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatListMessagesResponseMessagePayloadVariant2ActionAction2
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
    public static class ChatListMessagesResponseMessagePayloadVariant2ActionAction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatListMessagesResponseMessagePayloadVariant2ActionAction2 value)
        {
            return value switch
            {
                ChatListMessagesResponseMessagePayloadVariant2ActionAction2.Postback => "postback",
                ChatListMessagesResponseMessagePayloadVariant2ActionAction2.Say => "say",
                ChatListMessagesResponseMessagePayloadVariant2ActionAction2.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatListMessagesResponseMessagePayloadVariant2ActionAction2? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatListMessagesResponseMessagePayloadVariant2ActionAction2.Postback,
                "say" => ChatListMessagesResponseMessagePayloadVariant2ActionAction2.Say,
                "url" => ChatListMessagesResponseMessagePayloadVariant2ActionAction2.Url,
                _ => null,
            };
        }
    }
}