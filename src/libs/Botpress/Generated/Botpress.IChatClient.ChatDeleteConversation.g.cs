#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Delete Conversation<br/>
        /// Permanently deletes a [Conversation](#schema_conversation). It cannot be undone. Also immediately deletes corresponding [Messages](#schema_message).
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatDeleteConversationResponse> ChatDeleteConversationAsync(
            string xUserKey,
            string id,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}