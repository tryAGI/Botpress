#nullable enable

namespace Botpress
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List files for bot
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection"></param>
        /// <param name="tags"></param>
        /// <param name="ids"></param>
        /// <param name="indexed"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="xIntegrationName"></param>
        /// <param name="xUserId"></param>
        /// <param name="xUserRole"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task FilesListFilesAsync(
            string xBotId,
            string? nextToken = default,
            global::Botpress.FilesListFilesSortField? sortField = default,
            global::Botpress.FilesListFilesSortDirection? sortDirection = default,
            object? tags = default,
            global::System.Collections.Generic.IList<string>? ids = default,
            bool? indexed = default,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            string? xIntegrationName = default,
            string? xUserId = default,
            string? xUserRole = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}