
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Configuration of the bot
    /// </summary>
    public sealed partial class AdminBotConfiguration
    {
        /// <summary>
        /// Configuration data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Data { get; set; }

        /// <summary>
        /// Schema of the configuration in the `JSON schema` format. The configuration data is validated against this `JSON schema`.
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
        /// Initializes a new instance of the <see cref="AdminBotConfiguration" /> class.
        /// </summary>
        /// <param name="data">
        /// Configuration data
        /// </param>
        /// <param name="schema">
        /// Schema of the configuration in the `JSON schema` format. The configuration data is validated against this `JSON schema`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminBotConfiguration(
            object data,
            object schema)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBotConfiguration" /> class.
        /// </summary>
        public AdminBotConfiguration()
        {
        }
    }
}