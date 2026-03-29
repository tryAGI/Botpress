
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TablesTableSchemaPropertiesXZuiComputed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.TablesTableSchemaPropertiesXZuiComputedActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.TablesTableSchemaPropertiesXZuiComputedAction Action { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public global::System.Collections.Generic.IList<string>? Dependencies { get; set; }

        /// <summary>
        /// Prompt when action is "ai"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Code to execute when action is "code"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Model to use when action is "ai"<br/>
        /// Default Value: gpt-4o
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// ID of Workflow to execute when action is "workflow"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesTableSchemaPropertiesXZuiComputed" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="dependencies">
        /// Default Value: []
        /// </param>
        /// <param name="prompt">
        /// Prompt when action is "ai"
        /// </param>
        /// <param name="code">
        /// Code to execute when action is "code"
        /// </param>
        /// <param name="model">
        /// Model to use when action is "ai"<br/>
        /// Default Value: gpt-4o
        /// </param>
        /// <param name="workflowId">
        /// ID of Workflow to execute when action is "workflow"
        /// </param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TablesTableSchemaPropertiesXZuiComputed(
            global::Botpress.TablesTableSchemaPropertiesXZuiComputedAction action,
            global::System.Collections.Generic.IList<string>? dependencies,
            string? prompt,
            string? code,
            string? model,
            string? workflowId,
            bool? enabled)
        {
            this.Action = action;
            this.Dependencies = dependencies;
            this.Prompt = prompt;
            this.Code = code;
            this.Model = model;
            this.WorkflowId = workflowId;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TablesTableSchemaPropertiesXZuiComputed" /> class.
        /// </summary>
        public TablesTableSchemaPropertiesXZuiComputed()
        {
        }
    }
}