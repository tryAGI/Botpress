#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Get Message<br/>
        /// Retrieves the [Message](#schema_message) object for a valid identifier.
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatGetMessageResponse> ChatGetMessageAsync(
            string xUserKey,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}