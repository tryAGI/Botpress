
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatGetMessageResponseMessagePayloadVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatGetMessageResponseMessagePayloadVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatGetMessageResponseMessagePayloadVariant7Type value)
        {
            return value switch
            {
                ChatGetMessageResponseMessagePayloadVariant7Type.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatGetMessageResponseMessagePayloadVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "image" => ChatGetMessageResponseMessagePayloadVariant7Type.Image,
                _ => null,
            };
        }
    }
}