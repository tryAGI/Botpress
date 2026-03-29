#nullable enable

namespace Botpress
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Enables the search and filtering of rows within a table based on specific criteria. This operation supports complex queries for advanced data manipulation and retrieval.
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
        global::System.Threading.Tasks.Task TablesFindTableRowsAsync(
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