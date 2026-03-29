
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Type of the [State](#schema_state) (`conversation`, `user` or `bot`)
    /// </summary>
    public enum AdminBotStatesType
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
    public static class AdminBotStatesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminBotStatesType value)
        {
            return value switch
            {
                AdminBotStatesType.Bot => "bot",
                AdminBotStatesType.Conversation => "conversation",
                AdminBotStatesType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminBotStatesType? ToEnum(string value)
        {
            return value switch
            {
                "bot" => AdminBotStatesType.Bot,
                "conversation" => AdminBotStatesType.Conversation,
                "user" => AdminBotStatesType.User,
                _ => null,
            };
        }
    }
}