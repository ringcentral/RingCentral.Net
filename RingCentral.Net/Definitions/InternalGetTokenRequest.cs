namespace RingCentral
{
    /// <summary>
    ///     Token endpoint request parameters used in the "Guest" authorization flow
    ///     with the `guest` grant type
    /// </summary>
    public class InternalGetTokenRequest
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
        ///     Enum: authorization_code, password, urn:ietf:params:oauth:grant-type:jwt-bearer, partner_jwt, refresh_token,
        ///     ivr_pin, urn:ietf:params:oauth:grant-type:device_code, client_credentials, otp, guest
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        ///     For `otp` grant type only.
        ///     One-time password code
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
        ///     For `password` grant type only. User login name: email or phone number in E.164 format
        ///     Required
        /// </summary>
        public string username { get; set; }

        /// <summary>
        ///     For `password` grant type only. User's password
        ///     Required
        ///     Format: password
        /// </summary>
        public string password { get; set; }

        /// <summary>
        ///     For `password` grant type only. Optional. Extension short number. If a company number
        ///     is specified as a username, and extension is not specified, the
        ///     server will attempt to authenticate client as main company administrator
        ///     DEPRECATED: use extension number embedded into username string like `+16501234567*101`
        /// </summary>
        public string extension { get; set; }

        /// <summary>
        ///     IVR pin for pin-based authentication.
        ///     DEPRECATED: use a dedicated `ivr_pin` grant type instead
        /// </summary>
        public string pin { get; set; }

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

        /// <summary>
        ///     For `ivr_pin` grant type only. User's IVR pin.
        ///     Required
        /// </summary>
        public string ivr_pin { get; set; }

        /// <summary>
        ///     For `urn:ietf:params:oauth:grant-type:device_code` grant type only.
        ///     The device verification code as defined by [RFC-8628](https://datatracker.ietf.org/doc/html/rfc8628#section-3.4)
        ///     Required
        /// </summary>
        public string device_code { get; set; }

        /// <summary>
        ///     RingCentral Brand identifier.
        ///     Required
        /// </summary>
        public string brand_id { get; set; }

        /// <summary>
        ///     RingCentral internal account ID
        ///     Required
        /// </summary>
        public string account_id { get; set; }

        /// <summary>
        ///     The ID of the account on RingCentral partner's side
        ///     Required
        /// </summary>
        public string partner_account_id { get; set; }

        /// <summary>
        ///     Resource type for the guest access.
        ///     Required
        /// </summary>
        public string resource_type { get; set; }

        /// <summary>
        ///     Resource URL for the guest access.
        ///     Required
        /// </summary>
        public string resource { get; set; }
    }
}