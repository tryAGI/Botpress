
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageRequestPayloadLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        Location,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageRequestPayloadLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageRequestPayloadLocationType value)
        {
            return value switch
            {
                ChatCreateMessageRequestPayloadLocationType.Location => "location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageRequestPayloadLocationType? ToEnum(string value)
        {
            return value switch
            {
                "location" => ChatCreateMessageRequestPayloadLocationType.Location,
                _ => null,
            };
        }
    }
}