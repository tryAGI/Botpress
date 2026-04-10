#nullable enable

namespace Botpress
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create User<br/>
        /// Creates a new [User](#schema_user). This operation can only be called when using the shared encryption key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatCreateUserResponse> ChatCreateUserAsync(

            global::Botpress.ChatCreateUserRequest request,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create User<br/>
        /// Creates a new [User](#schema_user). This operation can only be called when using the shared encryption key.
        /// </summary>
        /// <param name="name">
        /// Name of the [User](#schema_user) (not a unique identifier)
        /// </param>
        /// <param name="pictureUrl">
        /// Picture url of the [User](#schema_user)
        /// </param>
        /// <param name="profile">
        /// Custom profile data of the [User](#schema_user) encoded as a string
        /// </param>
        /// <param name="id">
        /// Identifier of the [User](#schema_user)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatCreateUserResponse> ChatCreateUserAsync(
            string? name = default,
            string? pictureUrl = default,
            string? profile = default,
            string? id = default,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}