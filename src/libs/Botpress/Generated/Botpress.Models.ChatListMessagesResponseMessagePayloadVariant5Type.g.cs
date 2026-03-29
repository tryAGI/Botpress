
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatListMessagesResponseMessagePayloadVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        Dropdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatListMessagesResponseMessagePayloadVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatListMessagesResponseMessagePayloadVariant5Type value)
        {
            return value switch
            {
                ChatListMessagesResponseMessagePayloadVariant5Type.Dropdown => "dropdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatListMessagesResponseMessagePayloadVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "dropdown" => ChatListMessagesResponseMessagePayloadVariant5Type.Dropdown,
                _ => null,
            };
        }
    }
}