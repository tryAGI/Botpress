
#nullable enable

namespace Botpress
{
    /// <summary>
    /// The lifecycle status of the plugin. When a plugin is deprecated, it can no longer be installed.
    /// </summary>
    public enum AdminBotPluginsLifecycleStatus
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
    public static class AdminBotPluginsLifecycleStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminBotPluginsLifecycleStatus value)
        {
            return value switch
            {
                AdminBotPluginsLifecycleStatus.Deprecated => "deprecated",
                AdminBotPluginsLifecycleStatus.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminBotPluginsLifecycleStatus? ToEnum(string value)
        {
            return value switch
            {
                "deprecated" => AdminBotPluginsLifecycleStatus.Deprecated,
                "published" => AdminBotPluginsLifecycleStatus.Published,
                _ => null,
            };
        }
    }
}