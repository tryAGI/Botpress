
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCreateMessageRequestPayloadDropdownType
    {
        /// <summary>
        /// 
        /// </summary>
        Dropdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCreateMessageRequestPayloadDropdownTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCreateMessageRequestPayloadDropdownType value)
        {
            return value switch
            {
                ChatCreateMessageRequestPayloadDropdownType.Dropdown => "dropdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCreateMessageRequestPayloadDropdownType? ToEnum(string value)
        {
            return value switch
            {
                "dropdown" => ChatCreateMessageRequestPayloadDropdownType.Dropdown,
                _ => null,
            };
        }
    }
}