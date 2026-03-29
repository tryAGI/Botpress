
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatMessagePayloadVariant10Type
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessagePayloadVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessagePayloadVariant10Type value)
        {
            return value switch
            {
                ChatMessagePayloadVariant10Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessagePayloadVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatMessagePayloadVariant10Type.Text,
                _ => null,
            };
        }
    }
}