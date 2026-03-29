
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminUsage
    {
        /// <summary>
        /// Id of the usage that it is linked to. It can either be a workspace id or a bot id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Period of the quota that it is applied to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Period { get; set; }

        /// <summary>
        /// Value of the current usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Quota of the current usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quota")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Quota { get; set; }

        /// <summary>
        /// Usage type that can be used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminUsageTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminUsageType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminUsage" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the usage that it is linked to. It can either be a workspace id or a bot id
        /// </param>
        /// <param name="period">
        /// Period of the quota that it is applied to
        /// </param>
        /// <param name="value">
        /// Value of the current usage
        /// </param>
        /// <param name="quota">
        /// Quota of the current usage
        /// </param>
        /// <param name="type">
        /// Usage type that can be used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminUsage(
            string id,
            string period,
            double value,
            double quota,
            global::Botpress.AdminUsageType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Period = period ?? throw new global::System.ArgumentNullException(nameof(period));
            this.Value = value;
            this.Quota = quota;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminUsage" /> class.
        /// </summary>
        public AdminUsage()
        {
        }
    }
}