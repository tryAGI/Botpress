
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminIntegrationSandbox
    {
        /// <summary>
        /// VRL Script of the [Integration](#schema_integration) to extract the identifier from an incoming webhook used specifically for the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifierExtractScript")]
        public string? IdentifierExtractScript { get; set; }

        /// <summary>
        /// VRL Script of the [Integration](#schema_integration) to extract the message from an incoming webhook used specifically for the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageExtractScript")]
        public string? MessageExtractScript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationSandbox" /> class.
        /// </summary>
        /// <param name="identifierExtractScript">
        /// VRL Script of the [Integration](#schema_integration) to extract the identifier from an incoming webhook used specifically for the sandbox
        /// </param>
        /// <param name="messageExtractScript">
        /// VRL Script of the [Integration](#schema_integration) to extract the message from an incoming webhook used specifically for the sandbox
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminIntegrationSandbox(
            string? identifierExtractScript,
            string? messageExtractScript)
        {
            this.IdentifierExtractScript = identifierExtractScript;
            this.MessageExtractScript = messageExtractScript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationSandbox" /> class.
        /// </summary>
        public AdminIntegrationSandbox()
        {
        }
    }
}