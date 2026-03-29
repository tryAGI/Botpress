
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilesFileOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Integration,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilesFileOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilesFileOwnerType value)
        {
            return value switch
            {
                FilesFileOwnerType.Bot => "bot",
                FilesFileOwnerType.Integration => "integration",
                FilesFileOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilesFileOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "bot" => FilesFileOwnerType.Bot,
                "integration" => FilesFileOwnerType.Integration,
                "user" => FilesFileOwnerType.User,
                _ => null,
            };
        }
    }
}