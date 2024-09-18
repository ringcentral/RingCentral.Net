namespace RingCentral
{
    /// <summary>
    ///     Token endpoint request parameters used in the "Client Credentials" authorization flow
    ///     with the `client_credentials` grant type
    /// </summary>
    public class ClientCredentialsBase
    {
        /// <summary>
        ///     Grant type
        ///     Required
        ///     Enum: client_credentials
        /// </summary>
        public string grant_type { get; set; }
    }
}