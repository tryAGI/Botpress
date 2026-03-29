
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Status of the integration version verification
    /// </summary>
    public enum AdminIntegrationVerificationStatus
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
    public static class AdminIntegrationVerificationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminIntegrationVerificationStatus value)
        {
            return value switch
            {
                AdminIntegrationVerificationStatus.Approved => "approved",
                AdminIntegrationVerificationStatus.Pending => "pending",
                AdminIntegrationVerificationStatus.Rejected => "rejected",
                AdminIntegrationVerificationStatus.Unapproved => "unapproved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminIntegrationVerificationStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => AdminIntegrationVerificationStatus.Approved,
                "pending" => AdminIntegrationVerificationStatus.Pending,
                "rejected" => AdminIntegrationVerificationStatus.Rejected,
                "unapproved" => AdminIntegrationVerificationStatus.Unapproved,
                _ => null,
            };
        }
    }
}