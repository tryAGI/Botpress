
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdminListIntegrationsVerificationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Unapproved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminListIntegrationsVerificationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminListIntegrationsVerificationStatus value)
        {
            return value switch
            {
                AdminListIntegrationsVerificationStatus.Approved => "approved",
                AdminListIntegrationsVerificationStatus.Pending => "pending",
                AdminListIntegrationsVerificationStatus.Rejected => "rejected",
                AdminListIntegrationsVerificationStatus.Unapproved => "unapproved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminListIntegrationsVerificationStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => AdminListIntegrationsVerificationStatus.Approved,
                "pending" => AdminListIntegrationsVerificationStatus.Pending,
                "rejected" => AdminListIntegrationsVerificationStatus.Rejected,
                "unapproved" => AdminListIntegrationsVerificationStatus.Unapproved,
                _ => null,
            };
        }
    }
}