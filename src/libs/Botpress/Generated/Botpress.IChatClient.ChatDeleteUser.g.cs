#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Delete User<br/>
        /// Permanently deletes a [User](#schema_user). It cannot be undone.
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatDeleteUserResponse> ChatDeleteUserAsync(
            string xUserKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}