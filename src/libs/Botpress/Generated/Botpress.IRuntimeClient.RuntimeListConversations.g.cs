#nullable enable

namespace Botpress
{
    public partial interface IRuntimeClient
    {
        /// <summary>
        /// Retrieves a list of [Conversation](#schema_conversation) you’ve previously created. The conversations are returned in sorted order, with the most recent appearing first. The list can be filtered using [Tags](#tags).
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection"></param>
        /// <param name="tags"></param>
        /// <param name="participantIds"></param>
        /// <param name="integrationName"></param>
        /// <param name="channel"></param>
        /// <param name="afterDate"></param>
        /// <param name="beforeDate"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task RuntimeListConversationsAsync(
            string xBotId,
            string? nextToken = default,
            global::Botpress.RuntimeListConversationsSortField? sortField = default,
            global::Botpress.RuntimeListConversationsSortDirection? sortDirection = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            global::System.Collections.Generic.IList<string>? participantIds = default,
            string? integrationName = default,
            string? channel = default,
            string? afterDate = default,
            string? beforeDate = default,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}