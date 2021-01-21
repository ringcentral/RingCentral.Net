namespace RingCentral
{
    public class RevokeTokenRequest
    {
        /// <summary>
        /// </summary>
        public string client_assertion_type { get; set; }

        /// <summary>
        /// </summary>
        public string client_assertion { get; set; }

        /// <summary>
        /// Active access or refresh token to be revoked
        /// </summary>
        public string token { get; set; }
    }
}