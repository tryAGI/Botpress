#nullable enable

namespace Botpress
{
    public partial interface IRuntimeClient
    {
        /// <summary>
        /// Retrieves a list of [Participant](#schema_participant) for a given [Conversation](#schema_conversation).
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="id"></param>
        /// <param name="xBotId"></param>
        /// <param name="xIntegrationId"></param>
        /// <param name="xIntegrationAlias"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task RuntimeListParticipantsAsync(
            string id,
            string xBotId,
            string? nextToken = default,
            string? xIntegrationId = default,
            string? xIntegrationAlias = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}