
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageRequestPayloadAudioType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageRequestPayloadAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageRequestPayloadAudioType value)
        {
            return value switch
            {
                ChatCreateMessageRequestPayloadAudioType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageRequestPayloadAudioType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ChatCreateMessageRequestPayloadAudioType.Audio,
                _ => null,
            };
        }
    }
}