
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatGetMessageResponseMessagePayloadVariant3ItemActionAction
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
    public static class ChatGetMessageResponseMessagePayloadVariant3ItemActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatGetMessageResponseMessagePayloadVariant3ItemActionAction value)
        {
            return value switch
            {
                ChatGetMessageResponseMessagePayloadVariant3ItemActionAction.Postback => "postback",
                ChatGetMessageResponseMessagePayloadVariant3ItemActionAction.Say => "say",
                ChatGetMessageResponseMessagePayloadVariant3ItemActionAction.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatGetMessageResponseMessagePayloadVariant3ItemActionAction? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatGetMessageResponseMessagePayloadVariant3ItemActionAction.Postback,
                "say" => ChatGetMessageResponseMessagePayloadVariant3ItemActionAction.Say,
                "url" => ChatGetMessageResponseMessagePayloadVariant3ItemActionAction.Url,
                _ => null,
            };
        }
    }
}