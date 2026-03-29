
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdminListPublicIntegrationsDirection
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
    public static class AdminListPublicIntegrationsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminListPublicIntegrationsDirection value)
        {
            return value switch
            {
                AdminListPublicIntegrationsDirection.Asc => "asc",
                AdminListPublicIntegrationsDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminListPublicIntegrationsDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AdminListPublicIntegrationsDirection.Asc,
                "desc" => AdminListPublicIntegrationsDirection.Desc,
                _ => null,
            };
        }
    }
}