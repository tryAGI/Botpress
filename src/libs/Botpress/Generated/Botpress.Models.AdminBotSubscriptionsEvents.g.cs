
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Events that the bot is currently subscribed on (ex: "slack:reactionAdded"). If null, the bot is subscribed to all events.
    /// </summary>
    public sealed partial class AdminBotSubscriptionsEvents
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}