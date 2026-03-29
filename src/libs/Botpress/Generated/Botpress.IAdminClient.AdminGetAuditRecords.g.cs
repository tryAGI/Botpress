#nullable enable

namespace Botpress
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Get the audit records of a workspace, sorted from most recent to oldest.
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="id"></param>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task AdminGetAuditRecordsAsync(
            string id,
            string? nextToken = default,
            string? xMultipleIntegrations = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}