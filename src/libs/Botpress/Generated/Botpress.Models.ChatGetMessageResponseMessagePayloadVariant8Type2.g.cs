
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatGetMessageResponseMessagePayloadVariant8Type2
    {
        /// <summary>
        /// 
        /// </summary>
        Location,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatGetMessageResponseMessagePayloadVariant8Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatGetMessageResponseMessagePayloadVariant8Type2 value)
        {
            return value switch
            {
                ChatGetMessageResponseMessagePayloadVariant8Type2.Location => "location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatGetMessageResponseMessagePayloadVariant8Type2? ToEnum(string value)
        {
            return value switch
            {
                "location" => ChatGetMessageResponseMessagePayloadVariant8Type2.Location,
                _ => null,
            };
        }
    }
}