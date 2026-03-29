
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Global identifier configuration of the [Integration](#schema_integration)
    /// </summary>
    public sealed partial class AdminIntegrationIdentifier
    {
        /// <summary>
        /// VRL Script of the [Integration](#schema_integration) to handle incoming requests for a request that doesn't have an identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackHandlerScript")]
        public string? FallbackHandlerScript { get; set; }

        /// <summary>
        /// VRL Script of the [Integration](#schema_integration) to extract the identifier from an incoming webhook often use for OAuth
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extractScript")]
        public string? ExtractScript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationIdentifier" /> class.
        /// </summary>
        /// <param name="fallbackHandlerScript">
        /// VRL Script of the [Integration](#schema_integration) to handle incoming requests for a request that doesn't have an identifier
        /// </param>
        /// <param name="extractScript">
        /// VRL Script of the [Integration](#schema_integration) to extract the identifier from an incoming webhook often use for OAuth
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminIntegrationIdentifier(
            string? fallbackHandlerScript,
            string? extractScript)
        {
            this.FallbackHandlerScript = fallbackHandlerScript;
            this.ExtractScript = extractScript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationIdentifier" /> class.
        /// </summary>
        public AdminIntegrationIdentifier()
        {
        }
    }
}