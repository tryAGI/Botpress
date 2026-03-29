
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatMessagePayloadVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessagePayloadVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessagePayloadVariant6Type value)
        {
            return value switch
            {
                ChatMessagePayloadVariant6Type.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessagePayloadVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "file" => ChatMessagePayloadVariant6Type.File,
                _ => null,
            };
        }
    }
}