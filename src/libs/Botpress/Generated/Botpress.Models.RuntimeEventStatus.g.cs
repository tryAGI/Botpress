
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuntimeEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Ignored,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Processed,
        /// <summary>
        /// 
        /// </summary>
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RuntimeEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeEventStatus value)
        {
            return value switch
            {
                RuntimeEventStatus.Canceled => "canceled",
                RuntimeEventStatus.Failed => "failed",
                RuntimeEventStatus.Ignored => "ignored",
                RuntimeEventStatus.Pending => "pending",
                RuntimeEventStatus.Processed => "processed",
                RuntimeEventStatus.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => RuntimeEventStatus.Canceled,
                "failed" => RuntimeEventStatus.Failed,
                "ignored" => RuntimeEventStatus.Ignored,
                "pending" => RuntimeEventStatus.Pending,
                "processed" => RuntimeEventStatus.Processed,
                "scheduled" => RuntimeEventStatus.Scheduled,
                _ => null,
            };
        }
    }
}