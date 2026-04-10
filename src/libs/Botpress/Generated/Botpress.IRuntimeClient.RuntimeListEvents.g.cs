#nullable enable

namespace Botpress
{
    public partial interface IRuntimeClient
    {
        /// <summary>
        /// Retrieves a list of [Event](#schema_event) you’ve previously created. The events are returned in sorted order, with the most recent appearing first.
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="type"></param>
        /// <param name="conversationId"></param>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <param name="workflowId"></param>
        /// <param name="status"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task RuntimeListEventsAsync(
            string xBotId,
            string? nextToken = default,
            string? type = default,
            string? conversationId = default,
            string? userId = default,
            string? messageId = default,
            string? workflowId = default,
            global::Botpress.RuntimeListEventsStatus? status = default,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}