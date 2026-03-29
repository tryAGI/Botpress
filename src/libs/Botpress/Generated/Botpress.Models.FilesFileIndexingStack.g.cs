
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Indicates the indexing stack used to index this file. Present only when file has been successfully indexed. A value of "v2" denotes the latest stack, "v1" denotes the legacy stack.
    /// </summary>
    public enum FilesFileIndexingStack
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilesFileIndexingStackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilesFileIndexingStack value)
        {
            return value switch
            {
                FilesFileIndexingStack.V1 => "v1",
                FilesFileIndexingStack.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilesFileIndexingStack? ToEnum(string value)
        {
            return value switch
            {
                "v1" => FilesFileIndexingStack.V1,
                "v2" => FilesFileIndexingStack.V2,
                _ => null,
            };
        }
    }
}