
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatListMessagesResponseMessagePayloadVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Choice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatListMessagesResponseMessagePayloadVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatListMessagesResponseMessagePayloadVariant4Type value)
        {
            return value switch
            {
                ChatListMessagesResponseMessagePayloadVariant4Type.Choice => "choice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatListMessagesResponseMessagePayloadVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "choice" => ChatListMessagesResponseMessagePayloadVariant4Type.Choice,
                _ => null,
            };
        }
    }
}