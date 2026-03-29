
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageResponseMessagePayloadVariant4Type2
    {
        /// <summary>
        /// 
        /// </summary>
        Choice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageResponseMessagePayloadVariant4Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageResponseMessagePayloadVariant4Type2 value)
        {
            return value switch
            {
                ChatCreateMessageResponseMessagePayloadVariant4Type2.Choice => "choice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageResponseMessagePayloadVariant4Type2? ToEnum(string value)
        {
            return value switch
            {
                "choice" => ChatCreateMessageResponseMessagePayloadVariant4Type2.Choice,
                _ => null,
            };
        }
    }
}