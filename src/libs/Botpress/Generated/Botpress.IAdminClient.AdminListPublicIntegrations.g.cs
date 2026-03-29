#nullable enable

namespace Botpress
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// List public integration
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
        /// <param name="xMultipleIntegrations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task AdminListPublicIntegrationsAsync(
            string? nextToken = default,
            double? limit = default,
            string? name = default,
            string? version = default,
            string? interfaceId = default,
            string? interfaceName = default,
            string? installedByBotId = default,
            global::Botpress.AdminListPublicIntegrationsVerificationStatus? verificationStatus = default,
            string? search = default,
            global::Botpress.AdminListPublicIntegrationsSortBy? sortBy = default,
            global::Botpress.AdminListPublicIntegrationsDirection? direction = default,
            string? xMultipleIntegrations = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}