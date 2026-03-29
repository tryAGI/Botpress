
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatListMessagesResponseMessagePayloadVariant5Type2
    {
        /// <summary>
        /// 
        /// </summary>
        Dropdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatListMessagesResponseMessagePayloadVariant5Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatListMessagesResponseMessagePayloadVariant5Type2 value)
        {
            return value switch
            {
                ChatListMessagesResponseMessagePayloadVariant5Type2.Dropdown => "dropdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatListMessagesResponseMessagePayloadVariant5Type2? ToEnum(string value)
        {
            return value switch
            {
                "dropdown" => ChatListMessagesResponseMessagePayloadVariant5Type2.Dropdown,
                _ => null,
            };
        }
    }
}