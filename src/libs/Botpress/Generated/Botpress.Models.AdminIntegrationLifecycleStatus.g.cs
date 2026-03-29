
#nullable enable

namespace Botpress
{
    /// <summary>
    /// The lifecycle status of the integration. When an integration is deprecated, it can no longer be installed.
    /// </summary>
    public enum AdminIntegrationLifecycleStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Deprecated,
        /// <summary>
        /// 
        /// </summary>
        Published,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminIntegrationLifecycleStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminIntegrationLifecycleStatus value)
        {
            return value switch
            {
                AdminIntegrationLifecycleStatus.Deprecated => "deprecated",
                AdminIntegrationLifecycleStatus.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminIntegrationLifecycleStatus? ToEnum(string value)
        {
            return value switch
            {
                "deprecated" => AdminIntegrationLifecycleStatus.Deprecated,
                "published" => AdminIntegrationLifecycleStatus.Published,
                _ => null,
            };
        }
    }
}