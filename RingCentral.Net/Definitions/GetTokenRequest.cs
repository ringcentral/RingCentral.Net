namespace RingCentral
{
    // Request body for operation getToken
    public class GetTokenRequest
    {
        /// <summary>
        ///     Phone number linked to an account or extension in E.164 format with or without leading '+' sign
        /// </summary>
        public string username { get; set; }

        /// <summary>
        ///     User's password
        ///     Format: password
        /// </summary>
        public string password { get; set; }

        /// <summary>
        ///     Optional. Extension short number. If company number is specified as a username, and extension is not specified, the server will attempt to authenticate client as main company administrator
        /// </summary>
        public string extension { get; set; }

        /// <summary>
        ///     Grant type
        ///     Default: password
        ///     Enum: authorization_code, password, refresh_token, client_credentials, urn:ietf:params:oauth:grant-type:jwt-bearer
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        ///     Authorization code
        /// </summary>
        public string code { get; set; }

        /// <summary>
        ///     This is a callback URI which determines where the response is sent. The value of this parameter must exactly match one of the URIs you have provided for your app upon registration
        /// </summary>
        public string redirect_uri { get; set; }

        /// <summary>
        ///     Access token lifetime in seconds
        ///     Maximum: 3600
        ///     Minimum: 600
        ///     Format: int64
        ///     Default: 3600
        /// </summary>
        public long? access_token_ttl { get; set; }

        /// <summary>
        ///     Refresh token lifetime in seconds
        ///     Maximum: 604800
        ///     Format: int64
        ///     Default: 604800
        /// </summary>
        public long? refresh_token_ttl { get; set; }

        /// <summary>
        ///     List of API permissions to be used with access token. Can be omitted when requesting all permissions defined during the application registration phase
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        ///     Previously issued refresh token. This is the only formData field used for the Refresh Token Flow.
        /// </summary>
        public string refresh_token { get; set; }

        /// <summary>
        ///     The unique identifier of a client application. If not specified, the previously specified or auto generated value is used by default
        /// </summary>
        public string endpoint_id { get; set; }

        /// <summary>
        /// </summary>
        public string pin { get; set; }

        /// <summary>
        /// </summary>
        public string client_id { get; set; }

        /// <summary>
        /// </summary>
        public string account_id { get; set; }

        /// <summary>
        /// </summary>
        public string partner_account_id { get; set; }

        /// <summary>
        /// </summary>
        public string client_assertion_type { get; set; }

        /// <summary>
        /// </summary>
        public string client_assertion { get; set; }

        /// <summary>
        /// </summary>
        public string assertion { get; set; }

        /// <summary>
        /// </summary>
        public string brand_id { get; set; }

        /// <summary>
        /// </summary>
        public string code_verifier { get; set; }
    }
}