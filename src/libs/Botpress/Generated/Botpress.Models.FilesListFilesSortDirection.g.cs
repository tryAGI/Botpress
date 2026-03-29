
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilesListFilesSortDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilesListFilesSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilesListFilesSortDirection value)
        {
            return value switch
            {
                FilesListFilesSortDirection.Asc => "asc",
                FilesListFilesSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilesListFilesSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => FilesListFilesSortDirection.Asc,
                "desc" => FilesListFilesSortDirection.Desc,
                _ => null,
            };
        }
    }
}