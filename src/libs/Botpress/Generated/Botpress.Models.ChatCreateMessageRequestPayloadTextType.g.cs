
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageRequestPayloadTextType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageRequestPayloadTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageRequestPayloadTextType value)
        {
            return value switch
            {
                ChatCreateMessageRequestPayloadTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageRequestPayloadTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatCreateMessageRequestPayloadTextType.Text,
                _ => null,
            };
        }
    }
}