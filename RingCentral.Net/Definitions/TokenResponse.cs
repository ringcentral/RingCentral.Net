namespace RingCentral
{
    public class TokenResponse
    {
        /// <summary>
        /// </summary>
        public string access_token;

        /// <summary>
        /// </summary>
        public string token_type;

        /// <summary>
        /// </summary>
        public long? expires_in;

        /// <summary>
        /// </summary>
        public string refresh_token;

        /// <summary>
        /// </summary>
        public long? refresh_token_expires_in;

        /// <summary>
        /// </summary>
        public string scope;

        /// <summary>
        /// </summary>
        public string owner_id;

        /// <summary>
        /// </summary>
        public string endpoint_id;

        /// <summary>
        /// </summary>
        public string id_token;
    }
}