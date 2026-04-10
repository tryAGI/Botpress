#nullable enable

namespace Botpress
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Copy file
        /// </summary>
        /// <param name="idOrKey"></param>
        /// <param name="destinationKey"></param>
        /// <param name="xDestinationBotId"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="xIntegrationName"></param>
        /// <param name="xUserId"></param>
        /// <param name="xUserRole"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task FilesCopyFileAsync(
            string idOrKey,
            string destinationKey,
            string xBotId,
            string? xDestinationBotId = default,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            string? xIntegrationName = default,
            string? xUserId = default,
            string? xUserRole = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}