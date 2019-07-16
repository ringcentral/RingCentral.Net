namespace RingCentral
{
    public class RevokeTokenRequest
    {
        /// <summary>
        /// </summary>
        public string client_assertion_type;

        /// <summary>
        /// </summary>
        public string client_assertion;

        /// <summary>
        /// Active access or refresh token to be revoked
        /// </summary>
        public string token;
    }
}