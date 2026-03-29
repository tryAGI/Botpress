
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminBot
    {
        /// <summary>
        /// Id of the [Bot](#schema_bot)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation date of the [Bot](#schema_bot) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Updating date of the [Bot](#schema_bot) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Signing secret of the [Bot](#schema_bot). This field is only visible when creating a new bot or when rotating the signing secret of an existing bot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signingSecret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SigningSecret { get; set; }

        /// <summary>
        /// A mapping of integrations to their configuration. If the `x-multiple-integrations` header is present, this object is keyed by integration aliases. Otherwise, this object is keyed by integration ids.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotIntegrations2> Integrations { get; set; }

        /// <summary>
        /// A mapping of plugin aliases to their configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotPlugins2> Plugins { get; set; }

        /// <summary>
        /// Maximum execution time of the bot (in seconds).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxExecutionTime")]
        public double? MaxExecutionTime { get; set; }

        /// <summary>
        /// User object configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminBotUser User { get; set; }

        /// <summary>
        /// Conversation object configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminBotConversation Conversation { get; set; }

        /// <summary>
        /// Message object configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminBotMessage Message { get; set; }

        /// <summary>
        /// A mapping of states to their definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("states")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotStates2> States { get; set; }

        /// <summary>
        /// Configuration of the bot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminBotConfiguration Configuration { get; set; }

        /// <summary>
        /// Events definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotEvents2> Events { get; set; }

        /// <summary>
        /// Recurring events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recurringEvents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotRecurringEvents2> RecurringEvents { get; set; }

        /// <summary>
        /// Subscriptions of the bot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminBotSubscriptions Subscriptions { get; set; }

        /// <summary>
        /// Actions definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotActions2> Actions { get; set; }

        /// <summary>
        /// Tags of [Bot](#schema_bot)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Name of the [Bot](#schema_bot)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the [Bot](#schema_bot)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Last deployment date of the [Bot](#schema_bot) in the ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployedAt")]
        public global::System.DateTime? DeployedAt { get; set; }

        /// <summary>
        /// Indicates if the [Bot](#schema_bot) is a development bot; Development bots run locally and can install dev integrations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dev")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Dev { get; set; }

        /// <summary>
        /// List of secret names configured for this [Bot](#schema_bot)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Secrets { get; set; }

        /// <summary>
        /// Id of the user that created the bot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Indicates if the [Bot](#schema_bot) should be in always alive mode
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alwaysAlive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AlwaysAlive { get; set; }

        /// <summary>
        /// Status of the bot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminBotStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminBotStatus Status { get; set; }

        /// <summary>
        /// Media files associated with the [Bot](#schema_bot)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Botpress.AdminBotMedia> Medias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBot" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the [Bot](#schema_bot)
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the [Bot](#schema_bot) in ISO 8601 format
        /// </param>
        /// <param name="updatedAt">
        /// Updating date of the [Bot](#schema_bot) in ISO 8601 format
        /// </param>
        /// <param name="signingSecret">
        /// Signing secret of the [Bot](#schema_bot). This field is only visible when creating a new bot or when rotating the signing secret of an existing bot.
        /// </param>
        /// <param name="integrations">
        /// A mapping of integrations to their configuration. If the `x-multiple-integrations` header is present, this object is keyed by integration aliases. Otherwise, this object is keyed by integration ids.
        /// </param>
        /// <param name="plugins">
        /// A mapping of plugin aliases to their configuration
        /// </param>
        /// <param name="user">
        /// User object configuration
        /// </param>
        /// <param name="conversation">
        /// Conversation object configuration
        /// </param>
        /// <param name="message">
        /// Message object configuration
        /// </param>
        /// <param name="states">
        /// A mapping of states to their definition
        /// </param>
        /// <param name="configuration">
        /// Configuration of the bot
        /// </param>
        /// <param name="events">
        /// Events definition
        /// </param>
        /// <param name="recurringEvents">
        /// Recurring events
        /// </param>
        /// <param name="subscriptions">
        /// Subscriptions of the bot
        /// </param>
        /// <param name="actions">
        /// Actions definition
        /// </param>
        /// <param name="tags">
        /// Tags of [Bot](#schema_bot)
        /// </param>
        /// <param name="name">
        /// Name of the [Bot](#schema_bot)
        /// </param>
        /// <param name="dev">
        /// Indicates if the [Bot](#schema_bot) is a development bot; Development bots run locally and can install dev integrations
        /// </param>
        /// <param name="secrets">
        /// List of secret names configured for this [Bot](#schema_bot)
        /// </param>
        /// <param name="alwaysAlive">
        /// Indicates if the [Bot](#schema_bot) should be in always alive mode
        /// </param>
        /// <param name="status">
        /// Status of the bot
        /// </param>
        /// <param name="medias">
        /// Media files associated with the [Bot](#schema_bot)
        /// </param>
        /// <param name="maxExecutionTime">
        /// Maximum execution time of the bot (in seconds).
        /// </param>
        /// <param name="description">
        /// Description of the [Bot](#schema_bot)
        /// </param>
        /// <param name="deployedAt">
        /// Last deployment date of the [Bot](#schema_bot) in the ISO 8601 format
        /// </param>
        /// <param name="createdBy">
        /// Id of the user that created the bot
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminBot(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string signingSecret,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotIntegrations2> integrations,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotPlugins2> plugins,
            global::Botpress.AdminBotUser user,
            global::Botpress.AdminBotConversation conversation,
            global::Botpress.AdminBotMessage message,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotStates2> states,
            global::Botpress.AdminBotConfiguration configuration,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotEvents2> events,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotRecurringEvents2> recurringEvents,
            global::Botpress.AdminBotSubscriptions subscriptions,
            global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotActions2> actions,
            global::System.Collections.Generic.Dictionary<string, string> tags,
            string name,
            bool dev,
            global::System.Collections.Generic.IList<string> secrets,
            bool alwaysAlive,
            global::Botpress.AdminBotStatus status,
            global::System.Collections.Generic.IList<global::Botpress.AdminBotMedia> medias,
            double? maxExecutionTime,
            string? description,
            global::System.DateTime? deployedAt,
            string? createdBy)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.SigningSecret = signingSecret ?? throw new global::System.ArgumentNullException(nameof(signingSecret));
            this.Integrations = integrations ?? throw new global::System.ArgumentNullException(nameof(integrations));
            this.Plugins = plugins ?? throw new global::System.ArgumentNullException(nameof(plugins));
            this.MaxExecutionTime = maxExecutionTime;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Conversation = conversation ?? throw new global::System.ArgumentNullException(nameof(conversation));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.States = states ?? throw new global::System.ArgumentNullException(nameof(states));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.RecurringEvents = recurringEvents ?? throw new global::System.ArgumentNullException(nameof(recurringEvents));
            this.Subscriptions = subscriptions ?? throw new global::System.ArgumentNullException(nameof(subscriptions));
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.DeployedAt = deployedAt;
            this.Dev = dev;
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
            this.CreatedBy = createdBy;
            this.AlwaysAlive = alwaysAlive;
            this.Status = status;
            this.Medias = medias ?? throw new global::System.ArgumentNullException(nameof(medias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBot" /> class.
        /// </summary>
        public AdminBot()
        {
        }
    }
}