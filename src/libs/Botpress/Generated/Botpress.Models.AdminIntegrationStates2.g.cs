
#nullable enable

namespace Botpress
{
    /// <summary>
    /// State definition
    /// </summary>
    public sealed partial class AdminIntegrationStates2
    {
        /// <summary>
        /// Type of the [State](#schema_state) (`conversation`, `user` or `integration`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminIntegrationStatesTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminIntegrationStatesType Type { get; set; }

        /// <summary>
        /// Schema of the [State](#schema_state) in the `JSON schema` format. This `JSON schema` is going to be used for validating the state data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationStates2" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the [State](#schema_state) (`conversation`, `user` or `integration`)
        /// </param>
        /// <param name="schema">
        /// Schema of the [State](#schema_state) in the `JSON schema` format. This `JSON schema` is going to be used for validating the state data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminIntegrationStates2(
            global::Botpress.AdminIntegrationStatesType type,
            object schema)
        {
            this.Type = type;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminIntegrationStates2" /> class.
        /// </summary>
        public AdminIntegrationStates2()
        {
        }
    }
}