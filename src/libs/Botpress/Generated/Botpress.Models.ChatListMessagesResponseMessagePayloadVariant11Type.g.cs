
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatListMessagesResponseMessagePayloadVariant11Type
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatListMessagesResponseMessagePayloadVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatListMessagesResponseMessagePayloadVariant11Type value)
        {
            return value switch
            {
                ChatListMessagesResponseMessagePayloadVariant11Type.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatListMessagesResponseMessagePayloadVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "video" => ChatListMessagesResponseMessagePayloadVariant11Type.Video,
                _ => null,
            };
        }
    }
}