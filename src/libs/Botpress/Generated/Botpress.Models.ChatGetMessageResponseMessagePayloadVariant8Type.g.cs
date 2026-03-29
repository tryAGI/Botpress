
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatGetMessageResponseMessagePayloadVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        Location,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatGetMessageResponseMessagePayloadVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatGetMessageResponseMessagePayloadVariant8Type value)
        {
            return value switch
            {
                ChatGetMessageResponseMessagePayloadVariant8Type.Location => "location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatGetMessageResponseMessagePayloadVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "location" => ChatGetMessageResponseMessagePayloadVariant8Type.Location,
                _ => null,
            };
        }
    }
}