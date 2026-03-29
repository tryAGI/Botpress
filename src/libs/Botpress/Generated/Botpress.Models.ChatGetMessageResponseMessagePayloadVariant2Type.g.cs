
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatGetMessageResponseMessagePayloadVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Card,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatGetMessageResponseMessagePayloadVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatGetMessageResponseMessagePayloadVariant2Type value)
        {
            return value switch
            {
                ChatGetMessageResponseMessagePayloadVariant2Type.Card => "card",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatGetMessageResponseMessagePayloadVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "card" => ChatGetMessageResponseMessagePayloadVariant2Type.Card,
                _ => null,
            };
        }
    }
}