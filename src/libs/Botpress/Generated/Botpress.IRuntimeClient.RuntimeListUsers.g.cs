#nullable enable

namespace Botpress
{
    public partial interface IRuntimeClient
    {
        /// <summary>
        /// Retrieves a list of [User](#schema_user) previously created. The users are returned in sorted order, with the most recent appearing first. The list can be filtered using [Tags](/docs/developers/concepts/tags).
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="conversationId"></param>
        /// <param name="tags"></param>
        /// <param name="afterDate"></param>
        /// <param name="beforeDate"></param>
        /// <param name="rangeField"></param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task RuntimeListUsersAsync(
            string xBotId,
            string? nextToken = default,
            string? conversationId = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            string? afterDate = default,
            string? beforeDate = default,
            global::Botpress.RuntimeListUsersRangeField? rangeField = default,
            global::Botpress.RuntimeListUsersSortField? sortField = default,
            global::Botpress.RuntimeListUsersSortDirection? sortDirection = default,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}