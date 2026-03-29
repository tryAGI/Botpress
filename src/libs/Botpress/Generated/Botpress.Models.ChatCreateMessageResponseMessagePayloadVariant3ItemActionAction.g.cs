
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction
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
    public static class ChatCreateMessageResponseMessagePayloadVariant3ItemActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction value)
        {
            return value switch
            {
                ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction.Postback => "postback",
                ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction.Say => "say",
                ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction.Postback,
                "say" => ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction.Say,
                "url" => ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction.Url,
                _ => null,
            };
        }
    }
}