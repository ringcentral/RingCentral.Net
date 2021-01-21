namespace RingCentral
{
    public class TokenInfo
    {
        /// <summary>
        /// Access token to pass to subsequent API requests
        /// </summary>
        public string access_token { get; set; }

        /// <summary>
        /// Issued access token TTL (time to live), in seconds
        /// </summary>
        public long? expires_in { get; set; }

        /// <summary>
        /// Refresh token to get a new access token, when the issued one expires
        /// </summary>
        public string refresh_token { get; set; }

        /// <summary>
        /// Issued refresh token TTL (time to live), in seconds
        /// </summary>
        public long? refresh_token_expires_in { get; set; }

        /// <summary>
        /// List of permissions allowed with this access token, white-space separated
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        /// Type of token. The only possible value supported is Bearer. This value should be used when specifying access token in `Authorization` header of subsequent API requests
        /// </summary>
        public string token_type { get; set; }

        /// <summary>
        /// Extension identifier
        /// </summary>
        public string owner_id { get; set; }

        /// <summary>
        /// Application instance identifier
        /// </summary>
        public string endpoint_id { get; set; }

        /// <summary>
        /// </summary>
        public string id_token { get; set; }
    }
}