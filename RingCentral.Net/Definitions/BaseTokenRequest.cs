namespace RingCentral
{
    public class BaseTokenRequest
    {
        /// <summary>
        ///     Grant type
        ///     Required
        ///     Enum: authorization_code, password, refresh_token, client_credentials, urn:ietf:params:oauth:grant-type:jwt-bearer,
        ///     urn:ietf:params:oauth:grant-type:device_code, device_certificate, partner_jwt, guest, personal_jwt, otp, ivr_pin
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        ///     The list of application permissions (OAuth scopes) requested.
        ///     By default, it includes all permissions configured on
        ///     the client application registration
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        ///     The registered identifier of a client application.
        ///     Used to identify a client ONLY if the client authentication is not required and
        ///     corresponding credentials are not provided with this request
        ///     Example: AZwEVwGEcfGet2PCouA7K6
        /// </summary>
        public string client_id { get; set; }

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