
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Status of the [Workflow](#schema_workflow)
    /// </summary>
    public enum RuntimeWorkflowStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Listening,
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Timedout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RuntimeWorkflowStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeWorkflowStatus value)
        {
            return value switch
            {
                RuntimeWorkflowStatus.Cancelled => "cancelled",
                RuntimeWorkflowStatus.Completed => "completed",
                RuntimeWorkflowStatus.Failed => "failed",
                RuntimeWorkflowStatus.InProgress => "in_progress",
                RuntimeWorkflowStatus.Listening => "listening",
                RuntimeWorkflowStatus.Paused => "paused",
                RuntimeWorkflowStatus.Pending => "pending",
                RuntimeWorkflowStatus.Timedout => "timedout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeWorkflowStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => RuntimeWorkflowStatus.Cancelled,
                "completed" => RuntimeWorkflowStatus.Completed,
                "failed" => RuntimeWorkflowStatus.Failed,
                "in_progress" => RuntimeWorkflowStatus.InProgress,
                "listening" => RuntimeWorkflowStatus.Listening,
                "paused" => RuntimeWorkflowStatus.Paused,
                "pending" => RuntimeWorkflowStatus.Pending,
                "timedout" => RuntimeWorkflowStatus.Timedout,
                _ => null,
            };
        }
    }
}