
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilesFileAccessPolicie
    {
        /// <summary>
        /// 
        /// </summary>
        Integrations,
        /// <summary>
        /// 
        /// </summary>
        PublicContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilesFileAccessPolicieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilesFileAccessPolicie value)
        {
            return value switch
            {
                FilesFileAccessPolicie.Integrations => "integrations",
                FilesFileAccessPolicie.PublicContent => "public_content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilesFileAccessPolicie? ToEnum(string value)
        {
            return value switch
            {
                "integrations" => FilesFileAccessPolicie.Integrations,
                "public_content" => FilesFileAccessPolicie.PublicContent,
                _ => null,
            };
        }
    }
}