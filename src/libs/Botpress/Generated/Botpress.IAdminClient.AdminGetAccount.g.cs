#nullable enable

namespace Botpress
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Get details of the account authenticating with this endpoint.
        /// </summary>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task AdminGetAccountAsync(
            string? xMultipleIntegrations = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}