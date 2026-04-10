#nullable enable

namespace Botpress
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Get integration logs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="timeStart"></param>
        /// <param name="timeEnd"></param>
        /// <param name="level"></param>
        /// <param name="userId"></param>
        /// <param name="conversationId"></param>
        /// <param name="messageContains"></param>
        /// <param name="nextToken"></param>
        /// <param name="xWorkspaceId"></param>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task AdminGetIntegrationLogsAsync(
            string id,
            string timeStart,
            string xWorkspaceId,
            string? timeEnd = default,
            string? level = default,
            string? userId = default,
            string? conversationId = default,
            string? messageContains = default,
            string? nextToken = default,
            string? xMultipleIntegrations = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}