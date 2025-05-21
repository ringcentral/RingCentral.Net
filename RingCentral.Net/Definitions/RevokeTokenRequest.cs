namespace RingCentral
{
    public class RevokeTokenRequest
    {
        /// <summary>
        ///     Access or refresh token to be revoked (along with the entire OAuth session).
        ///     Required, unless it is passed via the `token` query parameter
        /// </summary>
        public string token { get; set; }

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
    }
}