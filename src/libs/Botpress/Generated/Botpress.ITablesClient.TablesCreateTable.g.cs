#nullable enable

namespace Botpress
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Initiates the creation of a new table based on the provided schema, excluding system-managed fields like IDs and timestamps.
        /// </summary>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="xIntegrationName"></param>
        /// <param name="xUserId"></param>
        /// <param name="xUserRole"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task TablesCreateTableAsync(
            string xBotId,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            string? xIntegrationName = default,
            string? xUserId = default,
            string? xUserRole = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Initiates the creation of a new table based on the provided schema, excluding system-managed fields like IDs and timestamps.
        /// </summary>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="xIntegrationName"></param>
        /// <param name="xUserId"></param>
        /// <param name="xUserRole"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.AutoSDKHttpResponse> TablesCreateTableAsResponseAsync(
            string xBotId,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            string? xIntegrationName = default,
            string? xUserId = default,
            string? xUserRole = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}