
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdminWorkspaceBillingVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
        /// <summary>
        /// 
        /// </summary>
        V2,
        /// <summary>
        /// 
        /// </summary>
        V3,
        /// <summary>
        /// 
        /// </summary>
        V4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminWorkspaceBillingVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminWorkspaceBillingVersion value)
        {
            return value switch
            {
                AdminWorkspaceBillingVersion.V1 => "v1",
                AdminWorkspaceBillingVersion.V2 => "v2",
                AdminWorkspaceBillingVersion.V3 => "v3",
                AdminWorkspaceBillingVersion.V4 => "v4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminWorkspaceBillingVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => AdminWorkspaceBillingVersion.V1,
                "v2" => AdminWorkspaceBillingVersion.V2,
                "v3" => AdminWorkspaceBillingVersion.V3,
                "v4" => AdminWorkspaceBillingVersion.V4,
                _ => null,
            };
        }
    }
}