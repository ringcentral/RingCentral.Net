namespace RingCentral
{
    public class RevokeTokenRequest
    {
        /// <summary>
        ///     Access or refresh token to be revoked
        ///     Required
        /// </summary>
        public string token { get; set; }

        /// <summary>
        ///     Client assertion type
        /// </summary>
        public string client_assertion_type { get; set; }

        /// <summary>
        ///     Client assertion
        /// </summary>
        public string client_assertion { get; set; }
    }
}