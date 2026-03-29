
#nullable enable

namespace Botpress
{
    /// <summary>
    /// The lifecycle status of the integration. When an integration is deprecated, it can no longer be installed.
    /// </summary>
    public enum AdminBotIntegrationsLifecycleStatus
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
    public static class AdminBotIntegrationsLifecycleStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminBotIntegrationsLifecycleStatus value)
        {
            return value switch
            {
                AdminBotIntegrationsLifecycleStatus.Deprecated => "deprecated",
                AdminBotIntegrationsLifecycleStatus.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminBotIntegrationsLifecycleStatus? ToEnum(string value)
        {
            return value switch
            {
                "deprecated" => AdminBotIntegrationsLifecycleStatus.Deprecated,
                "published" => AdminBotIntegrationsLifecycleStatus.Published,
                _ => null,
            };
        }
    }
}