
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuntimeListUsersSortDirection
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
    public static class RuntimeListUsersSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeListUsersSortDirection value)
        {
            return value switch
            {
                RuntimeListUsersSortDirection.Asc => "asc",
                RuntimeListUsersSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeListUsersSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => RuntimeListUsersSortDirection.Asc,
                "desc" => RuntimeListUsersSortDirection.Desc,
                _ => null,
            };
        }
    }
}