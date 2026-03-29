
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageRequestPayloadVariant2ActionAction
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
    public static class ChatCreateMessageRequestPayloadVariant2ActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageRequestPayloadVariant2ActionAction value)
        {
            return value switch
            {
                ChatCreateMessageRequestPayloadVariant2ActionAction.Postback => "postback",
                ChatCreateMessageRequestPayloadVariant2ActionAction.Say => "say",
                ChatCreateMessageRequestPayloadVariant2ActionAction.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageRequestPayloadVariant2ActionAction? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatCreateMessageRequestPayloadVariant2ActionAction.Postback,
                "say" => ChatCreateMessageRequestPayloadVariant2ActionAction.Say,
                "url" => ChatCreateMessageRequestPayloadVariant2ActionAction.Url,
                _ => null,
            };
        }
    }
}