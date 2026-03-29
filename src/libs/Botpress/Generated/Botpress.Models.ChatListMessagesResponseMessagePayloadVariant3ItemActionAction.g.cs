
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatListMessagesResponseMessagePayloadVariant3ItemActionAction
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
    public static class ChatListMessagesResponseMessagePayloadVariant3ItemActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatListMessagesResponseMessagePayloadVariant3ItemActionAction value)
        {
            return value switch
            {
                ChatListMessagesResponseMessagePayloadVariant3ItemActionAction.Postback => "postback",
                ChatListMessagesResponseMessagePayloadVariant3ItemActionAction.Say => "say",
                ChatListMessagesResponseMessagePayloadVariant3ItemActionAction.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatListMessagesResponseMessagePayloadVariant3ItemActionAction? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatListMessagesResponseMessagePayloadVariant3ItemActionAction.Postback,
                "say" => ChatListMessagesResponseMessagePayloadVariant3ItemActionAction.Say,
                "url" => ChatListMessagesResponseMessagePayloadVariant3ItemActionAction.Url,
                _ => null,
            };
        }
    }
}