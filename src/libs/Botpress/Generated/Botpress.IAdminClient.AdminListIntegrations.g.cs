#nullable enable

namespace Botpress
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// List integrations, supports filtering and sorting capabilities
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="limit"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="interfaceId"></param>
        /// <param name="interfaceName"></param>
        /// <param name="installedByBotId"></param>
        /// <param name="verificationStatus"></param>
        /// <param name="search"></param>
        /// <param name="sortBy"></param>
        /// <param name="direction"></param>
        /// <param name="visibility"></param>
        /// <param name="dev"></param>
        /// <param name="xWorkspaceId"></param>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task AdminListIntegrationsAsync(
            string xWorkspaceId,
            string? nextToken = default,
            double? limit = default,
            string? name = default,
            string? version = default,
            string? interfaceId = default,
            string? interfaceName = default,
            string? installedByBotId = default,
            global::Botpress.AdminListIntegrationsVerificationStatus? verificationStatus = default,
            string? search = default,
            global::Botpress.AdminListIntegrationsSortBy? sortBy = default,
            global::Botpress.AdminListIntegrationsDirection? direction = default,
            global::Botpress.AdminListIntegrationsVisibility? visibility = default,
            bool? dev = default,
            string? xMultipleIntegrations = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List integrations, supports filtering and sorting capabilities
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="limit"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="interfaceId"></param>
        /// <param name="interfaceName"></param>
        /// <param name="installedByBotId"></param>
        /// <param name="verificationStatus"></param>
        /// <param name="search"></param>
        /// <param name="sortBy"></param>
        /// <param name="direction"></param>
        /// <param name="visibility"></param>
        /// <param name="dev"></param>
        /// <param name="xWorkspaceId"></param>
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.AutoSDKHttpResponse> AdminListIntegrationsAsResponseAsync(
            string xWorkspaceId,
            string? nextToken = default,
            double? limit = default,
            string? name = default,
            string? version = default,
            string? interfaceId = default,
            string? interfaceName = default,
            string? installedByBotId = default,
            global::Botpress.AdminListIntegrationsVerificationStatus? verificationStatus = default,
            string? search = default,
            global::Botpress.AdminListIntegrationsSortBy? sortBy = default,
            global::Botpress.AdminListIntegrationsDirection? direction = default,
            global::Botpress.AdminListIntegrationsVisibility? visibility = default,
            bool? dev = default,
            string? xMultipleIntegrations = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}