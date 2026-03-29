#nullable enable

namespace Botpress
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Renames an existing column within a table to better reflect its content or usage. The operation targets a specific table and requires the current and new column names.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="xIntegrationName"></param>
        /// <param name="xUserId"></param>
        /// <param name="xUserRole"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task TablesRenameTableColumnAsync(
            string table,
            string xBotId,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            string? xIntegrationName = default,
            string? xUserId = default,
            string? xUserRole = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}