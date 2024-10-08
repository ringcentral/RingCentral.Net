namespace RingCentral
{
    /// <summary>
    ///     Token endpoint request parameters used in the "Client Credentials" authorization flow
    ///     with the `client_credentials` grant type
    /// </summary>
    public class ClientCredentialsByPartnerAccount
    {
        /// <summary>
        ///     Grant type
        ///     Required
        ///     Enum: client_credentials
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        ///     RingCentral Brand identifier
        ///     Required
        /// </summary>
        public string brand_id { get; set; }

        /// <summary>
        ///     The ID of the account on RingCentral partner's side
        ///     Required
        /// </summary>
        public string partner_account_id { get; set; }
    }
}