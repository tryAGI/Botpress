
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageRequestPayloadVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        Location,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageRequestPayloadVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageRequestPayloadVariant8Type value)
        {
            return value switch
            {
                ChatCreateMessageRequestPayloadVariant8Type.Location => "location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageRequestPayloadVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "location" => ChatCreateMessageRequestPayloadVariant8Type.Location,
                _ => null,
            };
        }
    }
}