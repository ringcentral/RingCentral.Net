namespace RingCentral
{
    /// <summary>
    ///     Token endpoint request parameters used in the "Refresh Token" flow
    ///     with the `refresh_token` grant type
    /// </summary>
    public class PublicGetTokenRequest
    {
        /// <summary>
        ///     The registered identifier of a client application.
        ///     Used to identify a client ONLY if the client authentication is not required and
        ///     corresponding credentials are not provided with this request
        ///     Example: AZwEVwGEcfGet2PCouA7K6
        /// </summary>
        public string client_id { get; set; }

        /// <summary>
        ///     Client assertion type for the `client_secret_jwt` or `private_key_jwt` client authentication types,
        ///     as defined by [RFC-7523](https://datatracker.ietf.org/doc/html/rfc7523#section-2.2).
        ///     This parameter is mandatory if the client authentication is required and a client decided to use one of these
        ///     authentication types
        ///     Enum: urn:ietf:params:oauth:client-assertion-type:jwt-bearer
        /// </summary>
        public string client_assertion_type { get; set; }

        /// <summary>
        ///     Client assertion (JWT) for the `client_secret_jwt` or `private_key_jwt` client authentication types,
        ///     as defined by [RFC-7523](https://datatracker.ietf.org/doc/html/rfc7523#section-2.2).
        ///     This parameter is mandatory if the client authentication is required and a client decided to use one of these
        ///     authentication types
        /// </summary>
        public string client_assertion { get; set; }

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

        /// <summary>
        ///     Grant type
        ///     Required
        ///     Enum: authorization_code, urn:ietf:params:oauth:grant-type:jwt-bearer, partner_jwt, refresh_token
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        ///     For `authorization_code` grant type only. User's authorization code
        ///     Required
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
        ///     For `authorization_code` grant type only.
        ///     The code verifier as defined by  the PKCE specification -
        ///     [RFC-7636 "Proof Key for Code Exchange by OAuth Public Clients"](https://datatracker.ietf.org/doc/html/rfc7636)
        /// </summary>
        public string code_verifier { get; set; }

        /// <summary>
        ///     For `urn:ietf:params:oauth:grant-type:jwt-bearer` or `partner_jwt` grant types only.
        ///     Authorization grant assertion (JWT)
        ///     as defined by [RFC-7523](https://datatracker.ietf.org/doc/html/rfc7523#section-2.1).
        ///     Required
        /// </summary>
        public string assertion { get; set; }

        /// <summary>
        ///     For `refresh_token` grant type only. Previously issued refresh token.
        ///     Required
        /// </summary>
        public string refresh_token { get; set; }
    }
}