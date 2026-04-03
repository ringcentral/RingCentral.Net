namespace RingCentral
{
    public class BaseTokenRequest
    {
        /// <summary>
        ///     The list of application permissions (OAuth scopes) requested.
        ///     By default, it includes all permissions configured on
        ///     the client application registration
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        ///     The unique identifier of a client application instance. If not
        ///     specified, the derived or auto-generated value will be used
        /// </summary>
        public string endpoint_id { get; set; }

        /// <summary>
        ///     Access token lifetime in seconds
        ///     Maximum: 3600
        ///     Minimum: 600
        ///     Format: int32
        ///     Default: 3600
        /// </summary>
        public long? access_token_ttl { get; set; }

        /// <summary>
        ///     Refresh token lifetime in seconds
        ///     Maximum: 2592000
        ///     Format: int32
        ///     Default: 604800
        /// </summary>
        public long? refresh_token_ttl { get; set; }
    }
}