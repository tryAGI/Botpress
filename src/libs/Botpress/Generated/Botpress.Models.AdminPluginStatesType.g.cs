
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Type of the [State](#schema_state) (`conversation`, `user` or `bot`)
    /// </summary>
    public enum AdminPluginStatesType
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
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminPluginStatesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminPluginStatesType value)
        {
            return value switch
            {
                AdminPluginStatesType.Bot => "bot",
                AdminPluginStatesType.Conversation => "conversation",
                AdminPluginStatesType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminPluginStatesType? ToEnum(string value)
        {
            return value switch
            {
                "bot" => AdminPluginStatesType.Bot,
                "conversation" => AdminPluginStatesType.Conversation,
                "user" => AdminPluginStatesType.User,
                _ => null,
            };
        }
    }
}