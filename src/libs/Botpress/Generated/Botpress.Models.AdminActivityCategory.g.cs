
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdminActivityCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Action,
        /// <summary>
        /// 
        /// </summary>
        AgentMessage,
        /// <summary>
        /// 
        /// </summary>
        BotMessage,
        /// <summary>
        /// 
        /// </summary>
        Capture,
        /// <summary>
        /// 
        /// </summary>
        Event,
        /// <summary>
        /// 
        /// </summary>
        Exception,
        /// <summary>
        /// 
        /// </summary>
        SubtaskStatus,
        /// <summary>
        /// 
        /// </summary>
        TaskStatus,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        UserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminActivityCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminActivityCategory value)
        {
            return value switch
            {
                AdminActivityCategory.Action => "action",
                AdminActivityCategory.AgentMessage => "agent_message",
                AdminActivityCategory.BotMessage => "bot_message",
                AdminActivityCategory.Capture => "capture",
                AdminActivityCategory.Event => "event",
                AdminActivityCategory.Exception => "exception",
                AdminActivityCategory.SubtaskStatus => "subtask_status",
                AdminActivityCategory.TaskStatus => "task_status",
                AdminActivityCategory.Unknown => "unknown",
                AdminActivityCategory.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminActivityCategory? ToEnum(string value)
        {
            return value switch
            {
                "action" => AdminActivityCategory.Action,
                "agent_message" => AdminActivityCategory.AgentMessage,
                "bot_message" => AdminActivityCategory.BotMessage,
                "capture" => AdminActivityCategory.Capture,
                "event" => AdminActivityCategory.Event,
                "exception" => AdminActivityCategory.Exception,
                "subtask_status" => AdminActivityCategory.SubtaskStatus,
                "task_status" => AdminActivityCategory.TaskStatus,
                "unknown" => AdminActivityCategory.Unknown,
                "user_message" => AdminActivityCategory.UserMessage,
                _ => null,
            };
        }
    }
}