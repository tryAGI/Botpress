#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Delete Message<br/>
        /// Permanently deletes a [Message](#schema_message). It cannot be undone.
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatDeleteMessageResponse> ChatDeleteMessageAsync(
            string xUserKey,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}