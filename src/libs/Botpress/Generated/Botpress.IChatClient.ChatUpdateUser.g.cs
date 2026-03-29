#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Update User<br/>
        /// Update [User](#schema_user)
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatUpdateUserResponse> ChatUpdateUserAsync(
            string xUserKey,

            global::Botpress.ChatUpdateUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update User<br/>
        /// Update [User](#schema_user)
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="name">
        /// Name of the [User](#schema_user) (not a unique identifier)
        /// </param>
        /// <param name="pictureUrl">
        /// Picture url of the [User](#schema_user)
        /// </param>
        /// <param name="profile">
        /// Custom profile data of the [User](#schema_user) encoded as a string
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatUpdateUserResponse> ChatUpdateUserAsync(
            string xUserKey,
            string? name = default,
            string? pictureUrl = default,
            string? profile = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}