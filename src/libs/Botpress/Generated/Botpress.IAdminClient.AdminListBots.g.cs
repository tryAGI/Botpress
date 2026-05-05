#nullable enable

namespace Botpress
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// List bots
        /// </summary>
        /// <param name="dev"></param>
        /// <param name="tags"></param>
        /// <param name="nextToken"></param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection"></param>
        /// <param name="xWorkspaceId"></param>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task AdminListBotsAsync(
            string xWorkspaceId,
            bool? dev = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            string? nextToken = default,
            global::Botpress.AdminListBotsSortField? sortField = default,
            global::Botpress.AdminListBotsSortDirection? sortDirection = default,
            string? xMultipleIntegrations = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List bots
        /// </summary>
        /// <param name="dev"></param>
        /// <param name="tags"></param>
        /// <param name="nextToken"></param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection"></param>
        /// <param name="xWorkspaceId"></param>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.AutoSDKHttpResponse> AdminListBotsAsResponseAsync(
            string xWorkspaceId,
            bool? dev = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            string? nextToken = default,
            global::Botpress.AdminListBotsSortField? sortField = default,
            global::Botpress.AdminListBotsSortDirection? sortDirection = default,
            string? xMultipleIntegrations = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}