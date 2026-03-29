
#nullable enable

namespace Botpress
{
    /// <summary>
    /// The plugin's visibility. Public plugins are available to all and cannot be updated without creating a new version. Unlisted plugins behave identically to public plugins, but they are not listed in the plugin hub. By default, plugins are private and only accessible to the workspace that created them.
    /// </summary>
    public enum AdminBotPluginsVisibility
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
    public static class AdminBotPluginsVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminBotPluginsVisibility value)
        {
            return value switch
            {
                AdminBotPluginsVisibility.Private => "private",
                AdminBotPluginsVisibility.Public => "public",
                AdminBotPluginsVisibility.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminBotPluginsVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => AdminBotPluginsVisibility.Private,
                "public" => AdminBotPluginsVisibility.Public,
                "unlisted" => AdminBotPluginsVisibility.Unlisted,
                _ => null,
            };
        }
    }
}