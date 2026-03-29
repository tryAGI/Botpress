
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdminWorkspacePlan
    {
        /// <summary>
        /// 
        /// </summary>
        Community,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminWorkspacePlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminWorkspacePlan value)
        {
            return value switch
            {
                AdminWorkspacePlan.Community => "community",
                AdminWorkspacePlan.Enterprise => "enterprise",
                AdminWorkspacePlan.Plus => "plus",
                AdminWorkspacePlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminWorkspacePlan? ToEnum(string value)
        {
            return value switch
            {
                "community" => AdminWorkspacePlan.Community,
                "enterprise" => AdminWorkspacePlan.Enterprise,
                "plus" => AdminWorkspacePlan.Plus,
                "team" => AdminWorkspacePlan.Team,
                _ => null,
            };
        }
    }
}