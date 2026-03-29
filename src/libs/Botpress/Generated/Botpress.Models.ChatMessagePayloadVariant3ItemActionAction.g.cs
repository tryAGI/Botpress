
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatMessagePayloadVariant3ItemActionAction
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
    public static class ChatMessagePayloadVariant3ItemActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessagePayloadVariant3ItemActionAction value)
        {
            return value switch
            {
                ChatMessagePayloadVariant3ItemActionAction.Postback => "postback",
                ChatMessagePayloadVariant3ItemActionAction.Say => "say",
                ChatMessagePayloadVariant3ItemActionAction.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessagePayloadVariant3ItemActionAction? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatMessagePayloadVariant3ItemActionAction.Postback,
                "say" => ChatMessagePayloadVariant3ItemActionAction.Say,
                "url" => ChatMessagePayloadVariant3ItemActionAction.Url,
                _ => null,
            };
        }
    }
}