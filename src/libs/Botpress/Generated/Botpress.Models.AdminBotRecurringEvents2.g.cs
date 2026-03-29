
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminBotRecurringEvents2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminBotRecurringEventsSchedule Schedule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Payload { get; set; }

        /// <summary>
        /// The number of times the recurring event failed to run. This counter resets once the recurring event runs successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedAttempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FailedAttempts { get; set; }

        /// <summary>
        /// The reason why the recurring event failed to run in the last attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastFailureReason")]
        public string? LastFailureReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotRecurringEvents2" /> class.
        /// </summary>
        /// <param name="schedule"></param>
        /// <param name="type"></param>
        /// <param name="payload"></param>
        /// <param name="failedAttempts">
        /// The number of times the recurring event failed to run. This counter resets once the recurring event runs successfully.
        /// </param>
        /// <param name="lastFailureReason">
        /// The reason why the recurring event failed to run in the last attempt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminBotRecurringEvents2(
            global::Botpress.AdminBotRecurringEventsSchedule schedule,
            string type,
            object payload,
            double failedAttempts,
            string? lastFailureReason)
        {
            this.Schedule = schedule ?? throw new global::System.ArgumentNullException(nameof(schedule));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.FailedAttempts = failedAttempts;
            this.LastFailureReason = lastFailureReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotRecurringEvents2" /> class.
        /// </summary>
        public AdminBotRecurringEvents2()
        {
        }
    }
}