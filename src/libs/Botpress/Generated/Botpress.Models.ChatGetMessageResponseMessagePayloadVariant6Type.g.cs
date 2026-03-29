
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatGetMessageResponseMessagePayloadVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatGetMessageResponseMessagePayloadVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatGetMessageResponseMessagePayloadVariant6Type value)
        {
            return value switch
            {
                ChatGetMessageResponseMessagePayloadVariant6Type.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatGetMessageResponseMessagePayloadVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "file" => ChatGetMessageResponseMessagePayloadVariant6Type.File,
                _ => null,
            };
        }
    }
}