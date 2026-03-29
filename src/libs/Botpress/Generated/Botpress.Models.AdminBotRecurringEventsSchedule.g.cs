
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminBotRecurringEventsSchedule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cron { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotRecurringEventsSchedule" /> class.
        /// </summary>
        /// <param name="cron"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminBotRecurringEventsSchedule(
            string cron)
        {
            this.Cron = cron ?? throw new global::System.ArgumentNullException(nameof(cron));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotRecurringEventsSchedule" /> class.
        /// </summary>
        public AdminBotRecurringEventsSchedule()
        {
        }
    }
}