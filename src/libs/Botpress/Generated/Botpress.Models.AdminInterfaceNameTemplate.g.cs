
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Template string optionaly used at build time by integrations implementing this interface to pick a name for actions and events.
    /// </summary>
    public sealed partial class AdminInterfaceNameTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("script")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Script { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminInterfaceNameTemplate" /> class.
        /// </summary>
        /// <param name="script"></param>
        /// <param name="language"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminInterfaceNameTemplate(
            string script,
            string language)
        {
            this.Script = script ?? throw new global::System.ArgumentNullException(nameof(script));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminInterfaceNameTemplate" /> class.
        /// </summary>
        public AdminInterfaceNameTemplate()
        {
        }
    }
}