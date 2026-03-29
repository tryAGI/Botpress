#nullable enable

namespace Botpress
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Inserts or updates rows based on a key. If a row exists, it is updated; otherwise, a new row is created.
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
        global::System.Threading.Tasks.Task TablesUpsertTableRowsAsync(
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