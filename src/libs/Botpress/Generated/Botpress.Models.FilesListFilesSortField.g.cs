
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilesListFilesSortField
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Key,
        /// <summary>
        /// 
        /// </summary>
        Size,
        /// <summary>
        /// 
        /// </summary>
        Status,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilesListFilesSortFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilesListFilesSortField value)
        {
            return value switch
            {
                FilesListFilesSortField.CreatedAt => "createdAt",
                FilesListFilesSortField.Key => "key",
                FilesListFilesSortField.Size => "size",
                FilesListFilesSortField.Status => "status",
                FilesListFilesSortField.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilesListFilesSortField? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => FilesListFilesSortField.CreatedAt,
                "key" => FilesListFilesSortField.Key,
                "size" => FilesListFilesSortField.Size,
                "status" => FilesListFilesSortField.Status,
                "updatedAt" => FilesListFilesSortField.UpdatedAt,
                _ => null,
            };
        }
    }
}