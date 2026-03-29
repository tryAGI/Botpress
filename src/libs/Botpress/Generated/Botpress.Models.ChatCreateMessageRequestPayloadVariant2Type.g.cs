
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageRequestPayloadVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Card,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageRequestPayloadVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageRequestPayloadVariant2Type value)
        {
            return value switch
            {
                ChatCreateMessageRequestPayloadVariant2Type.Card => "card",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageRequestPayloadVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "card" => ChatCreateMessageRequestPayloadVariant2Type.Card,
                _ => null,
            };
        }
    }
}