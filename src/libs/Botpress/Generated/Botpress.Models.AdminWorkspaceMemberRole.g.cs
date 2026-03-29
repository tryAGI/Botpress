
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdminWorkspaceMemberRole
    {
        /// <summary>
        /// 
        /// </summary>
        Administrator,
        /// <summary>
        /// 
        /// </summary>
        Billing,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        Manager,
        /// <summary>
        /// 
        /// </summary>
        Owner,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminWorkspaceMemberRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminWorkspaceMemberRole value)
        {
            return value switch
            {
                AdminWorkspaceMemberRole.Administrator => "administrator",
                AdminWorkspaceMemberRole.Billing => "billing",
                AdminWorkspaceMemberRole.Developer => "developer",
                AdminWorkspaceMemberRole.Manager => "manager",
                AdminWorkspaceMemberRole.Owner => "owner",
                AdminWorkspaceMemberRole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminWorkspaceMemberRole? ToEnum(string value)
        {
            return value switch
            {
                "administrator" => AdminWorkspaceMemberRole.Administrator,
                "billing" => AdminWorkspaceMemberRole.Billing,
                "developer" => AdminWorkspaceMemberRole.Developer,
                "manager" => AdminWorkspaceMemberRole.Manager,
                "owner" => AdminWorkspaceMemberRole.Owner,
                "viewer" => AdminWorkspaceMemberRole.Viewer,
                _ => null,
            };
        }
    }
}