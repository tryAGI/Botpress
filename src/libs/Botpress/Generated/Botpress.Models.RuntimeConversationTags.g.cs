
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Set of [Tags](/docs/developers/concepts/tags) that you can attach to a [Conversation](#schema_conversation). The set of [Tags](/docs/developers/concepts/tags) available on a [Conversation](#schema_conversation) is restricted by the list of [Tags](/docs/developers/concepts/tags) defined previously by the [Bot](#schema_bot). Individual keys can be unset by posting an empty value to them.
    /// </summary>
    public sealed partial class RuntimeConversationTags
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}