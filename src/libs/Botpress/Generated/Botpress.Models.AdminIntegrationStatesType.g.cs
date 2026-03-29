
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Type of the [State](#schema_state) (`conversation`, `user` or `integration`)
    /// </summary>
    public enum AdminIntegrationStatesType
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminIntegrationStatesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminIntegrationStatesType value)
        {
            return value switch
            {
                AdminIntegrationStatesType.Conversation => "conversation",
                AdminIntegrationStatesType.Integration => "integration",
                AdminIntegrationStatesType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminIntegrationStatesType? ToEnum(string value)
        {
            return value switch
            {
                "conversation" => AdminIntegrationStatesType.Conversation,
                "integration" => AdminIntegrationStatesType.Integration,
                "user" => AdminIntegrationStatesType.User,
                _ => null,
            };
        }
    }
}