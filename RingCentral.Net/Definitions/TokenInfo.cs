namespace RingCentral
{
    public class TokenInfo
    {
        /// <summary>
        /// Access token to pass to subsequent API requests
        /// </summary>
        public string access_token;

        /// <summary>
        /// Issued access token TTL (time to live), in seconds
        /// </summary>
        public long? expires_in;

        /// <summary>
        /// Refresh token to get a new access token, when the issued one expires
        /// </summary>
        public string refresh_token;

        /// <summary>
        /// Issued refresh token TTL (time to live), in seconds
        /// </summary>
        public long? refresh_token_expires_in;

        /// <summary>
        /// List of permissions allowed with this access token, white-space separated
        /// </summary>
        public string scope;

        /// <summary>
        /// Type of token. The only possible value supported is Bearer. This value should be used when specifying access token in Authorization header of subsequent API requests
        /// </summary>
        public string token_type;

        /// <summary>
        /// Extension identifier
        /// </summary>
        public string owner_id;

        /// <summary>
        /// Application instance identifier
        /// </summary>
        public string endpoint_id;
    }
}