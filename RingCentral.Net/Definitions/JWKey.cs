namespace RingCentral
{
    /// <summary>
    ///     Public key definition in JWK format
    ///     (see [RFC-7517](https://www.rfc-editor.org/rfc/rfc7517.html#section-4))
    /// </summary>
    public class JWKey
    {
        /// <summary>
        ///     Identifies the cryptographic algorithm family used with the key
        ///     Required
        ///     Example: RSA
        /// </summary>
        public string kty { get; set; }

        /// <summary>
        ///     Identifies the algorithm intended for use with the key
        ///     Required
        ///     Example: RS256
        /// </summary>
        public string alg { get; set; }

        /// <summary>
        ///     Identifies the intended use of the public key. This parameter is employed to indicate whether
        ///     a public key is used for encrypting data or verifying the signature on data.
        ///     Required
        ///     Example: sig
        ///     Enum: sig, enc
        /// </summary>
        public string use { get; set; }

        /// <summary>
        ///     An ID of the specific key within this keyset.
        ///     It is used to match the `kid` parameter in JOSE header of JWT.
        ///     Required
        /// </summary>
        public string kid { get; set; }

        /// <summary>
        ///     The "n" (modulus) parameter contains the modulus value for the RSA public key.
        ///     It is represented as a Base64urlUInt-encoded value. (User with "RSA" key type)
        ///     Required
        /// </summary>
        public string n { get; set; }

        /// <summary>
        ///     The "e" (exponent) parameter contains the exponent value for the RSA
        ///     public key.  It is represented as a Base64urlUInt-encoded value. (User with "RSA" key type)
        ///     Required
        /// </summary>
        public string e { get; set; }
    }
}