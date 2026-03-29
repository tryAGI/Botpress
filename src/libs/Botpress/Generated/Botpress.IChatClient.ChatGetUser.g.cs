#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Get User<br/>
        /// Retrieves the [User](#schema_user) object for a valid identifier.
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatGetUserResponse> ChatGetUserAsync(
            string xUserKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}