
#nullable enable

namespace Botpress
{
    /// <summary>
    /// The plugin's visibility. Public plugins are available to all and cannot be updated without creating a new version. Unlisted plugins behave identically to public plugins, but they are not listed in the plugin hub. By default, plugins are private and only accessible to the workspace that created them.
    /// </summary>
    public enum AdminPluginVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Unlisted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminPluginVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminPluginVisibility value)
        {
            return value switch
            {
                AdminPluginVisibility.Private => "private",
                AdminPluginVisibility.Public => "public",
                AdminPluginVisibility.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminPluginVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => AdminPluginVisibility.Private,
                "public" => AdminPluginVisibility.Public,
                "unlisted" => AdminPluginVisibility.Unlisted,
                _ => null,
            };
        }
    }
}