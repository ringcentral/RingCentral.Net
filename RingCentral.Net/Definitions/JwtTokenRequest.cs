namespace RingCentral
{
    /// <summary>
    ///     Token endpoint request parameters used in the "Personal JWT", "JWT Bearer" and "Partner JWT" authorization flows
    ///     with the `urn:ietf:params:oauth:grant-type:jwt-bearer` and `partner_jwt` grant types
    /// </summary>
    public class JwtTokenRequest
    {
        /// <summary>
        ///     Grant type
        ///     Required
        ///     Enum: urn:ietf:params:oauth:grant-type:jwt-bearer, partner_jwt
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        ///     For `urn:ietf:params:oauth:grant-type:jwt-bearer` or `partner_jwt` grant types only.
        ///     Authorization grant assertion (JWT)
        ///     as defined by [RFC-7523](https://datatracker.ietf.org/doc/html/rfc7523#section-2.1).
        ///     Required
        /// </summary>
        public string assertion { get; set; }
    }
}