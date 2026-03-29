
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuntimeGetStateType
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
    public static class RuntimeGetStateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeGetStateType value)
        {
            return value switch
            {
                RuntimeGetStateType.Bot => "bot",
                RuntimeGetStateType.Conversation => "conversation",
                RuntimeGetStateType.Integration => "integration",
                RuntimeGetStateType.User => "user",
                RuntimeGetStateType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeGetStateType? ToEnum(string value)
        {
            return value switch
            {
                "bot" => RuntimeGetStateType.Bot,
                "conversation" => RuntimeGetStateType.Conversation,
                "integration" => RuntimeGetStateType.Integration,
                "user" => RuntimeGetStateType.User,
                "workflow" => RuntimeGetStateType.Workflow,
                _ => null,
            };
        }
    }
}