
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuntimeGetOrSetStateType
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
    public static class RuntimeGetOrSetStateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeGetOrSetStateType value)
        {
            return value switch
            {
                RuntimeGetOrSetStateType.Bot => "bot",
                RuntimeGetOrSetStateType.Conversation => "conversation",
                RuntimeGetOrSetStateType.Integration => "integration",
                RuntimeGetOrSetStateType.User => "user",
                RuntimeGetOrSetStateType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeGetOrSetStateType? ToEnum(string value)
        {
            return value switch
            {
                "bot" => RuntimeGetOrSetStateType.Bot,
                "conversation" => RuntimeGetOrSetStateType.Conversation,
                "integration" => RuntimeGetOrSetStateType.Integration,
                "user" => RuntimeGetOrSetStateType.User,
                "workflow" => RuntimeGetOrSetStateType.Workflow,
                _ => null,
            };
        }
    }
}