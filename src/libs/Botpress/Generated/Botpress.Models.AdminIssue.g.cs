
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminIssue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSeenAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastSeenAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupedData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIssueGroupedData2> GroupedData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EventsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminIssueCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminIssueCategory Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolutionLink")]
        public string? ResolutionLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIssue" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="code"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastSeenAt"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="groupedData"></param>
        /// <param name="eventsCount"></param>
        /// <param name="category"></param>
        /// <param name="resolutionLink"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminIssue(
            string id,
            string code,
            global::System.DateTime createdAt,
            global::System.DateTime lastSeenAt,
            string title,
            string description,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIssueGroupedData2> groupedData,
            double eventsCount,
            global::Botpress.AdminIssueCategory category,
            string? resolutionLink)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.CreatedAt = createdAt;
            this.LastSeenAt = lastSeenAt;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.GroupedData = groupedData ?? throw new global::System.ArgumentNullException(nameof(groupedData));
            this.EventsCount = eventsCount;
            this.Category = category;
            this.ResolutionLink = resolutionLink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIssue" /> class.
        /// </summary>
        public AdminIssue()
        {
        }
    }
}