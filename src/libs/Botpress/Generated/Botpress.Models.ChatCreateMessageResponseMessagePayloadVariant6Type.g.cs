
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageResponseMessagePayloadVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageResponseMessagePayloadVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageResponseMessagePayloadVariant6Type value)
        {
            return value switch
            {
                ChatCreateMessageResponseMessagePayloadVariant6Type.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageResponseMessagePayloadVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "file" => ChatCreateMessageResponseMessagePayloadVariant6Type.File,
                _ => null,
            };
        }
    }
}