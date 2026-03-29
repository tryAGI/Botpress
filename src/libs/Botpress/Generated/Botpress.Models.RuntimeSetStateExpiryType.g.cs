
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuntimeSetStateExpiryType
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
    public static class RuntimeSetStateExpiryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeSetStateExpiryType value)
        {
            return value switch
            {
                RuntimeSetStateExpiryType.Bot => "bot",
                RuntimeSetStateExpiryType.Conversation => "conversation",
                RuntimeSetStateExpiryType.Integration => "integration",
                RuntimeSetStateExpiryType.User => "user",
                RuntimeSetStateExpiryType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeSetStateExpiryType? ToEnum(string value)
        {
            return value switch
            {
                "bot" => RuntimeSetStateExpiryType.Bot,
                "conversation" => RuntimeSetStateExpiryType.Conversation,
                "integration" => RuntimeSetStateExpiryType.Integration,
                "user" => RuntimeSetStateExpiryType.User,
                "workflow" => RuntimeSetStateExpiryType.Workflow,
                _ => null,
            };
        }
    }
}