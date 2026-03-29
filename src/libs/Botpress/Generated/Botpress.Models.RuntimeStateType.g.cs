
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Type of the [State](#schema_state) represents the resource type (`conversation`, `user`, `bot`, `integration` or `workflow`) that the state is related to
    /// </summary>
    public enum RuntimeStateType
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
    public static class RuntimeStateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeStateType value)
        {
            return value switch
            {
                RuntimeStateType.Bot => "bot",
                RuntimeStateType.Conversation => "conversation",
                RuntimeStateType.Integration => "integration",
                RuntimeStateType.User => "user",
                RuntimeStateType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeStateType? ToEnum(string value)
        {
            return value switch
            {
                "bot" => RuntimeStateType.Bot,
                "conversation" => RuntimeStateType.Conversation,
                "integration" => RuntimeStateType.Integration,
                "user" => RuntimeStateType.User,
                "workflow" => RuntimeStateType.Workflow,
                _ => null,
            };
        }
    }
}