
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdminListPublicIntegrationsVerificationStatus
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
    public static class AdminListPublicIntegrationsVerificationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminListPublicIntegrationsVerificationStatus value)
        {
            return value switch
            {
                AdminListPublicIntegrationsVerificationStatus.Approved => "approved",
                AdminListPublicIntegrationsVerificationStatus.Pending => "pending",
                AdminListPublicIntegrationsVerificationStatus.Rejected => "rejected",
                AdminListPublicIntegrationsVerificationStatus.Unapproved => "unapproved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminListPublicIntegrationsVerificationStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => AdminListPublicIntegrationsVerificationStatus.Approved,
                "pending" => AdminListPublicIntegrationsVerificationStatus.Pending,
                "rejected" => AdminListPublicIntegrationsVerificationStatus.Rejected,
                "unapproved" => AdminListPublicIntegrationsVerificationStatus.Unapproved,
                _ => null,
            };
        }
    }
}