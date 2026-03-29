
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Status of the integration version verification
    /// </summary>
    public enum AdminBotIntegrationsVerificationStatus
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
    public static class AdminBotIntegrationsVerificationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminBotIntegrationsVerificationStatus value)
        {
            return value switch
            {
                AdminBotIntegrationsVerificationStatus.Approved => "approved",
                AdminBotIntegrationsVerificationStatus.Pending => "pending",
                AdminBotIntegrationsVerificationStatus.Rejected => "rejected",
                AdminBotIntegrationsVerificationStatus.Unapproved => "unapproved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminBotIntegrationsVerificationStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => AdminBotIntegrationsVerificationStatus.Approved,
                "pending" => AdminBotIntegrationsVerificationStatus.Pending,
                "rejected" => AdminBotIntegrationsVerificationStatus.Rejected,
                "unapproved" => AdminBotIntegrationsVerificationStatus.Unapproved,
                _ => null,
            };
        }
    }
}