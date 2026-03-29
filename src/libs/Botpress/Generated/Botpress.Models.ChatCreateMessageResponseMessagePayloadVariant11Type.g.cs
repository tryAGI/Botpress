
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageResponseMessagePayloadVariant11Type
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageResponseMessagePayloadVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageResponseMessagePayloadVariant11Type value)
        {
            return value switch
            {
                ChatCreateMessageResponseMessagePayloadVariant11Type.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageResponseMessagePayloadVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "video" => ChatCreateMessageResponseMessagePayloadVariant11Type.Video,
                _ => null,
            };
        }
    }
}