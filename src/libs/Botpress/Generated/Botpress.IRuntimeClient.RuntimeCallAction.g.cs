#nullable enable

namespace Botpress
{
    public partial interface IRuntimeClient
    {
        /// <summary>
        /// Call an action
        /// </summary>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task RuntimeCallActionAsync(
            string xBotId,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call an action
        /// </summary>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.AutoSDKHttpResponse> RuntimeCallActionAsResponseAsync(
            string xBotId,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}