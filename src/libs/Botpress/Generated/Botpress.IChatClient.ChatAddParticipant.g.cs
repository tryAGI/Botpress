#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Add Participant<br/>
        /// Add a [Participant](#schema_user) to a [Conversation](#schema_conversation).
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatAddParticipantResponse> ChatAddParticipantAsync(
            string xUserKey,
            string conversationId,

            global::Botpress.ChatAddParticipantRequest request,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Participant<br/>
        /// Add a [Participant](#schema_user) to a [Conversation](#schema_conversation).
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.AutoSDKHttpResponse<global::Botpress.ChatAddParticipantResponse>> ChatAddParticipantAsResponseAsync(
            string xUserKey,
            string conversationId,

            global::Botpress.ChatAddParticipantRequest request,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Participant<br/>
        /// Add a [Participant](#schema_user) to a [Conversation](#schema_conversation).
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="conversationId"></param>
        /// <param name="userId">
        /// User id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatAddParticipantResponse> ChatAddParticipantAsync(
            string xUserKey,
            string conversationId,
            string userId,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}