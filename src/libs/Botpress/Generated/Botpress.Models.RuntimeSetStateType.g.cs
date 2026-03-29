
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuntimeSetStateType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Conversation,
        /// <summary>
        /// 
        /// </summary>
        Integration,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RuntimeSetStateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeSetStateType value)
        {
            return value switch
            {
                RuntimeSetStateType.Bot => "bot",
                RuntimeSetStateType.Conversation => "conversation",
                RuntimeSetStateType.Integration => "integration",
                RuntimeSetStateType.User => "user",
                RuntimeSetStateType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeSetStateType? ToEnum(string value)
        {
            return value switch
            {
                "bot" => RuntimeSetStateType.Bot,
                "conversation" => RuntimeSetStateType.Conversation,
                "integration" => RuntimeSetStateType.Integration,
                "user" => RuntimeSetStateType.User,
                "workflow" => RuntimeSetStateType.Workflow,
                _ => null,
            };
        }
    }
}