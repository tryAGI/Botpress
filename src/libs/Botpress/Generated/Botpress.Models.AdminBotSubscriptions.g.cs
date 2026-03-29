
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Subscriptions of the bot
    /// </summary>
    public sealed partial class AdminBotSubscriptions
    {
        /// <summary>
        /// Events that the bot is currently subscribed on (ex: "slack:reactionAdded"). If null, the bot is subscribed to all events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotSubscriptionsEvents2>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotSubscriptions" /> class.
        /// </summary>
        /// <param name="events">
        /// Events that the bot is currently subscribed on (ex: "slack:reactionAdded"). If null, the bot is subscribed to all events.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminBotSubscriptions(
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotSubscriptionsEvents2>? events)
        {
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotSubscriptions" /> class.
        /// </summary>
        public AdminBotSubscriptions()
        {
        }
    }
}