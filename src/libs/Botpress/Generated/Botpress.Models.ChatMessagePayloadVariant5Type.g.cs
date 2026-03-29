
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatMessagePayloadVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        Dropdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessagePayloadVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessagePayloadVariant5Type value)
        {
            return value switch
            {
                ChatMessagePayloadVariant5Type.Dropdown => "dropdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessagePayloadVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "dropdown" => ChatMessagePayloadVariant5Type.Dropdown,
                _ => null,
            };
        }
    }
}