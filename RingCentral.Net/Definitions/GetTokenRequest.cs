namespace RingCentral
{
    public class GetTokenRequest
    {
        /// <summary>
        ///     For `password` grant type only. User login name: email or phone number in E.164 format
        /// </summary>
        public string username { get; set; }

        /// <summary>
        ///     For `password` grant type only. User's password
        ///     Format: password
        /// </summary>
        public string password { get; set; }

        /// <summary>
        ///     For `password` grant type only. Optional. Extension short number. If company number
        ///     is specified as a username, and extension is not specified, the
        ///     server will attempt to authenticate client as main company administrator
        ///     DEPRECATED: use extension number embedded into username string like `+16501234567*101`
        /// </summary>
        public string extension { get; set; }

        /// <summary>
        ///     Grant type
        ///     Required
        ///     Enum: authorization_code, password, refresh_token, client_credentials, urn:ietf:params:oauth:grant-type:jwt-bearer,
        ///     urn:ietf:params:oauth:grant-type:device_code, partner_jwt
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        ///     For `authorization_code` grant type only. User's authorization code
        /// </summary>
        public string code { get; set; }

        /// <summary>
        ///     For `authorization_code` grant type only. This is a callback URI which determines where the response
        ///     is sent. The value of this parameter must exactly match one of
        ///     the URIs you have provided for your app upon registration
        ///     Format: uri
        /// </summary>
        public string redirect_uri { get; set; }

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
        ///     Maximum: 604800
        ///     Format: int32
        ///     Default: 604800
        /// </summary>
        public long? refresh_token_ttl { get; set; }

        /// <summary>
        ///     List of application permissions to be used with access token.
        ///     By default the scope includes all permissions configured during
        ///     the application registration phase
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        ///     For `refresh_token` grant type only. Previously issued refresh token.
        /// </summary>
        public string refresh_token { get; set; }

        /// <summary>
        ///     The unique identifier of a client application instance. If not
        ///     specified, the derived or auto generated value will be used
        /// </summary>
        public string endpoint_id { get; set; }

        /// <summary>
        /// </summary>
        public string pin { get; set; }

        /// <summary>
        ///     OAuth client identifier (if not specified via `Authorization` header)
        /// </summary>
        public string client_id { get; set; }

        /// <summary>
        /// </summary>
        public string account_id { get; set; }

        /// <summary>
        /// </summary>
        public string partner_account_id { get; set; }

        /// <summary>
        ///     Client assertion type
        /// </summary>
        public string client_assertion_type { get; set; }

        /// <summary>
        ///     Client assertion
        /// </summary>
        public string client_assertion { get; set; }

        /// <summary>
        ///     For `jwt_bearer` grant type only. Assertion
        /// </summary>
        public string assertion { get; set; }

        /// <summary>
        /// </summary>
        public string brand_id { get; set; }

        /// <summary>
        ///     PKCE code verifier
        /// </summary>
        public string code_verifier { get; set; }

        /// <summary>
        /// </summary>
        public string device_code { get; set; }
    }
}