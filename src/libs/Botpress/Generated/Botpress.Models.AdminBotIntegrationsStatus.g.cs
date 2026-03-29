
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdminBotIntegrationsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Registered,
        /// <summary>
        /// 
        /// </summary>
        RegistrationFailed,
        /// <summary>
        /// 
        /// </summary>
        RegistrationPending,
        /// <summary>
        /// 
        /// </summary>
        Unregistered,
        /// <summary>
        /// 
        /// </summary>
        UnregistrationFailed,
        /// <summary>
        /// 
        /// </summary>
        UnregistrationPending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminBotIntegrationsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminBotIntegrationsStatus value)
        {
            return value switch
            {
                AdminBotIntegrationsStatus.Registered => "registered",
                AdminBotIntegrationsStatus.RegistrationFailed => "registration_failed",
                AdminBotIntegrationsStatus.RegistrationPending => "registration_pending",
                AdminBotIntegrationsStatus.Unregistered => "unregistered",
                AdminBotIntegrationsStatus.UnregistrationFailed => "unregistration_failed",
                AdminBotIntegrationsStatus.UnregistrationPending => "unregistration_pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminBotIntegrationsStatus? ToEnum(string value)
        {
            return value switch
            {
                "registered" => AdminBotIntegrationsStatus.Registered,
                "registration_failed" => AdminBotIntegrationsStatus.RegistrationFailed,
                "registration_pending" => AdminBotIntegrationsStatus.RegistrationPending,
                "unregistered" => AdminBotIntegrationsStatus.Unregistered,
                "unregistration_failed" => AdminBotIntegrationsStatus.UnregistrationFailed,
                "unregistration_pending" => AdminBotIntegrationsStatus.UnregistrationPending,
                _ => null,
            };
        }
    }
}