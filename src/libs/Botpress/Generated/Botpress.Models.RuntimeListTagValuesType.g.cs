
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuntimeListTagValuesType
    {
        /// <summary>
        /// 
        /// </summary>
        Conversation,
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RuntimeListTagValuesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeListTagValuesType value)
        {
            return value switch
            {
                RuntimeListTagValuesType.Conversation => "conversation",
                RuntimeListTagValuesType.Message => "message",
                RuntimeListTagValuesType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeListTagValuesType? ToEnum(string value)
        {
            return value switch
            {
                "conversation" => RuntimeListTagValuesType.Conversation,
                "message" => RuntimeListTagValuesType.Message,
                "user" => RuntimeListTagValuesType.User,
                _ => null,
            };
        }
    }
}