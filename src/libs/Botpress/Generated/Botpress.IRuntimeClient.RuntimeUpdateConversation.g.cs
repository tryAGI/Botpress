#nullable enable

namespace Botpress
{
    public partial interface IRuntimeClient
    {
        /// <summary>
        /// Update a [Conversation](#schema_conversation) object by setting the values of the parameters passed. Any parameters not provided will be left unchanged.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task RuntimeUpdateConversationAsync(
            string id,
            string xBotId,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}