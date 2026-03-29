#nullable enable

namespace Botpress
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Remove a member of a workspace
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xWorkspaceId"></param>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task AdminDeleteWorkspaceMemberAsync(
            string id,
            string xWorkspaceId,
            string? xMultipleIntegrations = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}