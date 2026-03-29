
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2
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
    public static class ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2 value)
        {
            return value switch
            {
                ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2.Postback => "postback",
                ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2.Say => "say",
                ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2.Postback,
                "say" => ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2.Say,
                "url" => ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2.Url,
                _ => null,
            };
        }
    }
}