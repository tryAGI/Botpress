#nullable enable

namespace Botpress
{
    public partial interface IRuntimeClient
    {
        /// <summary>
        /// Updates the [State](#schema_state) expiry.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task RuntimeSetStateExpiryAsync(
            global::Botpress.RuntimeSetStateExpiryType type,
            string id,
            string name,
            string xBotId,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}