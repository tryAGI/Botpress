
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Status of the bot
    /// </summary>
    public enum AdminBotStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Deleting,
        /// <summary>
        /// 
        /// </summary>
        Deploying,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminBotStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminBotStatus value)
        {
            return value switch
            {
                AdminBotStatus.Active => "active",
                AdminBotStatus.Deleting => "deleting",
                AdminBotStatus.Deploying => "deploying",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminBotStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => AdminBotStatus.Active,
                "deleting" => AdminBotStatus.Deleting,
                "deploying" => AdminBotStatus.Deploying,
                _ => null,
            };
        }
    }
}