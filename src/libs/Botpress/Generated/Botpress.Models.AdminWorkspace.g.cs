
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminWorkspace
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BotCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminWorkspaceBillingVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminWorkspaceBillingVersion BillingVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminWorkspacePlanJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminWorkspacePlan Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Blocked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spendingLimit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SpendingLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("about")]
        public string? About { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profilePicture")]
        public string? ProfilePicture { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contactEmail")]
        public string? ContactEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("socialAccounts")]
        public global::System.Collections.Generic.IList<string>? SocialAccounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPublic")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeTrialId")]
        public string? ActiveTrialId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminWorkspace" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="ownerId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="botCount"></param>
        /// <param name="billingVersion"></param>
        /// <param name="plan"></param>
        /// <param name="blocked"></param>
        /// <param name="spendingLimit"></param>
        /// <param name="about"></param>
        /// <param name="profilePicture"></param>
        /// <param name="contactEmail"></param>
        /// <param name="website"></param>
        /// <param name="socialAccounts">
        /// Default Value: []
        /// </param>
        /// <param name="isPublic"></param>
        /// <param name="handle"></param>
        /// <param name="activeTrialId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminWorkspace(
            string id,
            string name,
            string ownerId,
            string createdAt,
            string updatedAt,
            double botCount,
            global::Botpress.AdminWorkspaceBillingVersion billingVersion,
            global::Botpress.AdminWorkspacePlan plan,
            bool blocked,
            double spendingLimit,
            string? about,
            string? profilePicture,
            string? contactEmail,
            string? website,
            global::System.Collections.Generic.IList<string>? socialAccounts,
            bool? isPublic,
            string? handle,
            string? activeTrialId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.BotCount = botCount;
            this.BillingVersion = billingVersion;
            this.Plan = plan;
            this.Blocked = blocked;
            this.SpendingLimit = spendingLimit;
            this.About = about;
            this.ProfilePicture = profilePicture;
            this.ContactEmail = contactEmail;
            this.Website = website;
            this.SocialAccounts = socialAccounts;
            this.IsPublic = isPublic;
            this.Handle = handle;
            this.ActiveTrialId = activeTrialId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminWorkspace" /> class.
        /// </summary>
        public AdminWorkspace()
        {
        }
    }
}