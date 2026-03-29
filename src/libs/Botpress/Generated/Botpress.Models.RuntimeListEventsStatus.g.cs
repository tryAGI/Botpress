
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuntimeListEventsStatus
    {
        /// <summary>
        /// pending, ignored, processed, failed.
        /// </summary>
        Failed,
        /// <summary>
        /// pending, ignored, processed, failed.
        /// </summary>
        Ignored,
        /// <summary>
        /// pending, ignored, processed, failed.
        /// </summary>
        Pending,
        /// <summary>
        /// pending, ignored, processed, failed.
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
    public static class RuntimeListEventsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeListEventsStatus value)
        {
            return value switch
            {
                RuntimeListEventsStatus.Failed => "failed",
                RuntimeListEventsStatus.Ignored => "ignored",
                RuntimeListEventsStatus.Pending => "pending",
                RuntimeListEventsStatus.Processed => "processed",
                RuntimeListEventsStatus.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeListEventsStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => RuntimeListEventsStatus.Failed,
                "ignored" => RuntimeListEventsStatus.Ignored,
                "pending" => RuntimeListEventsStatus.Pending,
                "processed" => RuntimeListEventsStatus.Processed,
                "scheduled" => RuntimeListEventsStatus.Scheduled,
                _ => null,
            };
        }
    }
}