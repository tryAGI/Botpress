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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.ChatGetUserResponse> ChatGetUserAsync(
            string xUserKey,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get User<br/>
        /// Retrieves the [User](#schema_user) object for a valid identifier.
        /// </summary>
        /// <param name="xUserKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Botpress.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Botpress.AutoSDKHttpResponse<global::Botpress.ChatGetUserResponse>> ChatGetUserAsResponseAsync(
            string xUserKey,
            global::Botpress.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}