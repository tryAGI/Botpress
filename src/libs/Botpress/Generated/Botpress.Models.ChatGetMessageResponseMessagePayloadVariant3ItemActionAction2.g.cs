
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2
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
    public static class ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2 value)
        {
            return value switch
            {
                ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2.Postback => "postback",
                ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2.Say => "say",
                ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2.Postback,
                "say" => ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2.Say,
                "url" => ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2.Url,
                _ => null,
            };
        }
    }
}