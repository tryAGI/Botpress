#nullable enable

namespace Botpress
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// List public workspaces
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="search"></param>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task AdminListPublicWorkspacesAsync(
            string? nextToken = default,
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            string? search = default,
            string? xMultipleIntegrations = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List public workspaces
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="search"></param>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.AutoSDKHttpResponse> AdminListPublicWorkspacesAsResponseAsync(
            string? nextToken = default,
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            string? search = default,
            string? xMultipleIntegrations = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}