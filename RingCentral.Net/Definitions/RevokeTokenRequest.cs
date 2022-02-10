namespace RingCentral
{
    /// <summary>
    ///     Request body for operation revokeToken
    /// </summary>
    public class RevokeTokenRequest
    {
        /// <summary>
        /// </summary>
        public string client_assertion_type { get; set; }

        /// <summary>
        /// </summary>
        public string client_assertion { get; set; }

        /// <summary>
        ///     Active access or refresh token to be revoked
        ///     Required
        /// </summary>
        public string token { get; set; }
    }
}