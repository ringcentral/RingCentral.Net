namespace RingCentral
{
    /// <summary>
    ///     Token endpoint request parameters used in the "Client Credentials" authorization flow with the `client_credentials`
    ///     grant type
    /// </summary>
    public class ClientCredentialsByBrand
    {
        /// <summary>
        ///     Grant type
        ///     Enum: client_credentials
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        ///     RingCentral Brand identifier
        ///     Required
        /// </summary>
        public string brand_id { get; set; }
    }
}