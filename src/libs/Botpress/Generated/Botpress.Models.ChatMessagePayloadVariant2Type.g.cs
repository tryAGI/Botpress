
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatMessagePayloadVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Card,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessagePayloadVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessagePayloadVariant2Type value)
        {
            return value switch
            {
                ChatMessagePayloadVariant2Type.Card => "card",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessagePayloadVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "card" => ChatMessagePayloadVariant2Type.Card,
                _ => null,
            };
        }
    }
}