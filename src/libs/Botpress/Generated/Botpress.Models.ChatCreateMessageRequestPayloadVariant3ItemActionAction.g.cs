
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageRequestPayloadVariant3ItemActionAction
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
    public static class ChatCreateMessageRequestPayloadVariant3ItemActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageRequestPayloadVariant3ItemActionAction value)
        {
            return value switch
            {
                ChatCreateMessageRequestPayloadVariant3ItemActionAction.Postback => "postback",
                ChatCreateMessageRequestPayloadVariant3ItemActionAction.Say => "say",
                ChatCreateMessageRequestPayloadVariant3ItemActionAction.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageRequestPayloadVariant3ItemActionAction? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatCreateMessageRequestPayloadVariant3ItemActionAction.Postback,
                "say" => ChatCreateMessageRequestPayloadVariant3ItemActionAction.Say,
                "url" => ChatCreateMessageRequestPayloadVariant3ItemActionAction.Url,
                _ => null,
            };
        }
    }
}