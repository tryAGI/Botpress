#nullable enable

namespace Botpress
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Get Bot Issue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="issueId"></param>
        /// <param name="xWorkspaceId"></param>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task AdminGetBotIssueAsync(
            string id,
            string issueId,
            string xWorkspaceId,
            string? xMultipleIntegrations = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}