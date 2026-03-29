
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdminListIntegrationsDirection
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
    public static class AdminListIntegrationsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminListIntegrationsDirection value)
        {
            return value switch
            {
                AdminListIntegrationsDirection.Asc => "asc",
                AdminListIntegrationsDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminListIntegrationsDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AdminListIntegrationsDirection.Asc,
                "desc" => AdminListIntegrationsDirection.Desc,
                _ => null,
            };
        }
    }
}