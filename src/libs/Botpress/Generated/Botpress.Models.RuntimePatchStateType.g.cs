
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuntimePatchStateType
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
    public static class RuntimePatchStateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimePatchStateType value)
        {
            return value switch
            {
                RuntimePatchStateType.Bot => "bot",
                RuntimePatchStateType.Conversation => "conversation",
                RuntimePatchStateType.Integration => "integration",
                RuntimePatchStateType.User => "user",
                RuntimePatchStateType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimePatchStateType? ToEnum(string value)
        {
            return value switch
            {
                "bot" => RuntimePatchStateType.Bot,
                "conversation" => RuntimePatchStateType.Conversation,
                "integration" => RuntimePatchStateType.Integration,
                "user" => RuntimePatchStateType.User,
                "workflow" => RuntimePatchStateType.Workflow,
                _ => null,
            };
        }
    }
}