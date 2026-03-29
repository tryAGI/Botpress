#nullable enable

namespace Botpress
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Search files
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="query"></param>
        /// <param name="contextDepth"></param>
        /// <param name="limit"></param>
        /// <param name="consolidate"></param>
        /// <param name="includeBreadcrumb"></param>
        /// <param name="withContext"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="xIntegrationName"></param>
        /// <param name="xUserId"></param>
        /// <param name="xUserRole"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task FilesSearchFilesAsync(
            string query,
            string xBotId,
            object? tags = default,
            int? contextDepth = default,
            int? limit = default,
            bool? consolidate = default,
            bool? includeBreadcrumb = default,
            bool? withContext = default,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            string? xIntegrationName = default,
            string? xUserId = default,
            string? xUserRole = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}