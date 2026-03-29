
#nullable enable

namespace Botpress
{
    /// <summary>
    /// The integration's visibility. Public integrations are available to all and cannot be updated without creating a new version. Unlisted integrations behave identically to public integrations, but they are not listed in the integration hub. By default, integrations are private and only accessible to the workspace that created them.
    /// </summary>
    public enum AdminBotIntegrationsVisibility
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
    public static class AdminBotIntegrationsVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminBotIntegrationsVisibility value)
        {
            return value switch
            {
                AdminBotIntegrationsVisibility.Private => "private",
                AdminBotIntegrationsVisibility.Public => "public",
                AdminBotIntegrationsVisibility.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminBotIntegrationsVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => AdminBotIntegrationsVisibility.Private,
                "public" => AdminBotIntegrationsVisibility.Public,
                "unlisted" => AdminBotIntegrationsVisibility.Unlisted,
                _ => null,
            };
        }
    }
}