
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Action definition
    /// </summary>
    public sealed partial class AdminPluginActions2
    {
        /// <summary>
        /// Title of the action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description of the action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable")]
        public bool? Billable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheable")]
        public bool? Cacheable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminPluginActionsInput Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminPluginActionsOutput Output { get; set; }

        /// <summary>
        /// Optional attributes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminPluginActions2" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="title">
        /// Title of the action
        /// </param>
        /// <param name="description">
        /// Description of the action
        /// </param>
        /// <param name="billable"></param>
        /// <param name="cacheable"></param>
        /// <param name="attributes">
        /// Optional attributes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminPluginActions2(
            global::Botpress.AdminPluginActionsInput input,
            global::Botpress.AdminPluginActionsOutput output,
            string? title,
            string? description,
            bool? billable,
            bool? cacheable,
            global::System.Collections.Generic.Dictionary<string, string>? attributes)
        {
            this.Title = title;
            this.Description = description;
            this.Billable = billable;
            this.Cacheable = cacheable;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminPluginActions2" /> class.
        /// </summary>
        public AdminPluginActions2()
        {
        }
    }
}