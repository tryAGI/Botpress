
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageRequestPayloadMarkdownType
    {
        /// <summary>
        /// 
        /// </summary>
        Markdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageRequestPayloadMarkdownTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageRequestPayloadMarkdownType value)
        {
            return value switch
            {
                ChatCreateMessageRequestPayloadMarkdownType.Markdown => "markdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageRequestPayloadMarkdownType? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => ChatCreateMessageRequestPayloadMarkdownType.Markdown,
                _ => null,
            };
        }
    }
}