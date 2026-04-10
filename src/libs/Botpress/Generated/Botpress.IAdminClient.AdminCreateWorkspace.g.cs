#nullable enable

namespace Botpress
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Create workspace
        /// </summary>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task AdminCreateWorkspaceAsync(
            string? xMultipleIntegrations = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}