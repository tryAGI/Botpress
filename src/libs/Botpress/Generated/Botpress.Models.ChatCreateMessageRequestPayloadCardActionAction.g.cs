
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageRequestPayloadCardActionAction
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
    public static class ChatCreateMessageRequestPayloadCardActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageRequestPayloadCardActionAction value)
        {
            return value switch
            {
                ChatCreateMessageRequestPayloadCardActionAction.Postback => "postback",
                ChatCreateMessageRequestPayloadCardActionAction.Say => "say",
                ChatCreateMessageRequestPayloadCardActionAction.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageRequestPayloadCardActionAction? ToEnum(string value)
        {
            return value switch
            {
                "postback" => ChatCreateMessageRequestPayloadCardActionAction.Postback,
                "say" => ChatCreateMessageRequestPayloadCardActionAction.Say,
                "url" => ChatCreateMessageRequestPayloadCardActionAction.Url,
                _ => null,
            };
        }
    }
}