
#nullable enable

namespace Botpress
{
    /// <summary>
    /// The lifecycle status of the plugin. When a plugin is deprecated, it can no longer be installed.
    /// </summary>
    public enum AdminPluginLifecycleStatus
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
    public static class AdminPluginLifecycleStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminPluginLifecycleStatus value)
        {
            return value switch
            {
                AdminPluginLifecycleStatus.Deprecated => "deprecated",
                AdminPluginLifecycleStatus.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminPluginLifecycleStatus? ToEnum(string value)
        {
            return value switch
            {
                "deprecated" => AdminPluginLifecycleStatus.Deprecated,
                "published" => AdminPluginLifecycleStatus.Published,
                _ => null,
            };
        }
    }
}