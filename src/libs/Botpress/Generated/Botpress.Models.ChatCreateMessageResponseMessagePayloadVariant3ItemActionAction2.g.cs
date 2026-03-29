
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2
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
    public static class ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2 value)
        {
            return value switch
            {
                ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2.Postback => "postback",
                ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2.Say => "say",
                ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2.Postback,
                "say" => ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2.Say,
                "url" => ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2.Url,
                _ => null,
            };
        }
    }
}