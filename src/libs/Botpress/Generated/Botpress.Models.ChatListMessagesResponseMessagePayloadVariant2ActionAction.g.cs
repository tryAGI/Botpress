
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatListMessagesResponseMessagePayloadVariant2ActionAction
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
    public static class ChatListMessagesResponseMessagePayloadVariant2ActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatListMessagesResponseMessagePayloadVariant2ActionAction value)
        {
            return value switch
            {
                ChatListMessagesResponseMessagePayloadVariant2ActionAction.Postback => "postback",
                ChatListMessagesResponseMessagePayloadVariant2ActionAction.Say => "say",
                ChatListMessagesResponseMessagePayloadVariant2ActionAction.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatListMessagesResponseMessagePayloadVariant2ActionAction? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatListMessagesResponseMessagePayloadVariant2ActionAction.Postback,
                "say" => ChatListMessagesResponseMessagePayloadVariant2ActionAction.Say,
                "url" => ChatListMessagesResponseMessagePayloadVariant2ActionAction.Url,
                _ => null,
            };
        }
    }
}