
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminBotStates2
    {
        /// <summary>
        /// Type of the [State](#schema_state) (`conversation`, `user` or `bot`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.AdminBotStatesTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.AdminBotStatesType Type { get; set; }

        /// <summary>
        /// Schema of the [State](#schema_state) in the `JSON schema` format. This `JSON schema` is going to be used for validating the state data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Expiry of the [State](#schema_state) in milliseconds. The state will expire if it is idle for the configured value. By default, a state doesn't expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiry")]
        public double? Expiry { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotStates2" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the [State](#schema_state) (`conversation`, `user` or `bot`)
        /// </param>
        /// <param name="schema">
        /// Schema of the [State](#schema_state) in the `JSON schema` format. This `JSON schema` is going to be used for validating the state data.
        /// </param>
        /// <param name="expiry">
        /// Expiry of the [State](#schema_state) in milliseconds. The state will expire if it is idle for the configured value. By default, a state doesn't expire.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminBotStates2(
            global::Botpress.AdminBotStatesType type,
            object schema,
            double? expiry)
        {
            this.Type = type;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Expiry = expiry;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotStates2" /> class.
        /// </summary>
        public AdminBotStates2()
        {
        }
    }
}