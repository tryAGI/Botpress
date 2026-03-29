
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatGetMessageResponseMessagePayloadVariant11Type
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatGetMessageResponseMessagePayloadVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatGetMessageResponseMessagePayloadVariant11Type value)
        {
            return value switch
            {
                ChatGetMessageResponseMessagePayloadVariant11Type.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatGetMessageResponseMessagePayloadVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "video" => ChatGetMessageResponseMessagePayloadVariant11Type.Video,
                _ => null,
            };
        }
    }
}