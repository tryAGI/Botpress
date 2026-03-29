
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Workflow definition
    /// </summary>
    public sealed partial class RuntimeWorkflow
    {
        /// <summary>
        /// Id of the [Workflow](#schema_workflow)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Status of the [Workflow](#schema_workflow)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.RuntimeWorkflowStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.RuntimeWorkflowStatus Status { get; set; }

        /// <summary>
        /// Input provided to the [Workflow](#schema_workflow)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// Data returned by the [Workflow](#schema_workflow) output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Output { get; set; }

        /// <summary>
        /// Parent [Workflow](#schema_workflow) id is the parent [Workflow](#schema_workflow) that created this [Workflow](#schema_workflow)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentWorkflowId")]
        public string? ParentWorkflowId { get; set; }

        /// <summary>
        /// Conversation id related to this [Workflow](#schema_workflow)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// User id related to this [Workflow](#schema_workflow)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Creation date of the [Workflow](#schema_workflow) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Updating date of the [Workflow](#schema_workflow) in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The date when the [Workflow](#schema_workflow) completed in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// If the [Workflow](#schema_workflow) fails this is the reason behind it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureReason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// The timeout date when the [Workflow](#schema_workflow) will fail in the ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime TimeoutAt { get; set; }

        /// <summary>
        /// Set of [Tags](/docs/developers/concepts/tags) that you can attach to a [Workflow](#schema_workflow). Individual keys can be unset by posting an empty value to them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeWorkflow" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the [Workflow](#schema_workflow)
        /// </param>
        /// <param name="name">
        /// Name of the workflow
        /// </param>
        /// <param name="status">
        /// Status of the [Workflow](#schema_workflow)
        /// </param>
        /// <param name="input">
        /// Input provided to the [Workflow](#schema_workflow)
        /// </param>
        /// <param name="output">
        /// Data returned by the [Workflow](#schema_workflow) output
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the [Workflow](#schema_workflow) in ISO 8601 format
        /// </param>
        /// <param name="updatedAt">
        /// Updating date of the [Workflow](#schema_workflow) in ISO 8601 format
        /// </param>
        /// <param name="timeoutAt">
        /// The timeout date when the [Workflow](#schema_workflow) will fail in the ISO 8601 format
        /// </param>
        /// <param name="tags">
        /// Set of [Tags](/docs/developers/concepts/tags) that you can attach to a [Workflow](#schema_workflow). Individual keys can be unset by posting an empty value to them.
        /// </param>
        /// <param name="parentWorkflowId">
        /// Parent [Workflow](#schema_workflow) id is the parent [Workflow](#schema_workflow) that created this [Workflow](#schema_workflow)
        /// </param>
        /// <param name="conversationId">
        /// Conversation id related to this [Workflow](#schema_workflow)
        /// </param>
        /// <param name="userId">
        /// User id related to this [Workflow](#schema_workflow)
        /// </param>
        /// <param name="completedAt">
        /// The date when the [Workflow](#schema_workflow) completed in ISO 8601 format
        /// </param>
        /// <param name="failureReason">
        /// If the [Workflow](#schema_workflow) fails this is the reason behind it
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuntimeWorkflow(
            string id,
            string name,
            global::Botpress.RuntimeWorkflowStatus status,
            object input,
            object output,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime timeoutAt,
            global::System.Collections.Generic.Dictionary<string, string> tags,
            string? parentWorkflowId,
            string? conversationId,
            string? userId,
            global::System.DateTime? completedAt,
            string? failureReason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.ParentWorkflowId = parentWorkflowId;
            this.ConversationId = conversationId;
            this.UserId = userId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CompletedAt = completedAt;
            this.FailureReason = failureReason;
            this.TimeoutAt = timeoutAt;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeWorkflow" /> class.
        /// </summary>
        public RuntimeWorkflow()
        {
        }
    }
}