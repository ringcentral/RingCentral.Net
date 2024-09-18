namespace RingCentral
{
    /// <summary>
    ///     Token endpoint request parameters used in the "Authorization Code" and "Authorization code with PKCE" flows
    ///     with the `authorization_code` grant type
    /// </summary>
    public class AuthCodeTokenRequest
    {
        /// <summary>
        ///     Grant type
        ///     Required
        ///     Enum: authorization_code
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
    }
}