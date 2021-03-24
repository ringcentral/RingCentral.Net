namespace RingCentral
{
    public class TokenInfo
    {
        /// <summary>
        /// Access token to pass to subsequent API requests
        /// Example: U1BCMDFUMDRKV1MwMXxzLFSvXdw5PHMsVLEn_MrtcyxUsw
        /// </summary>
        public string access_token { get; set; }

        /// <summary>
        /// Issued access token TTL (time to live), in seconds
        /// Example: 7199
        /// </summary>
        public long? expires_in { get; set; }

        /// <summary>
        /// Refresh token to get a new access token, when the issued one expires
        /// Example: U1BCMDFUMDRKV1MwMXxzLFL4ec6A0XMsUv9wLriecyxS_w
        /// </summary>
        public string refresh_token { get; set; }

        /// <summary>
        /// Issued refresh token TTL (time to live), in seconds
        /// Example: 604799
        /// </summary>
        public long? refresh_token_expires_in { get; set; }

        /// <summary>
        /// List of permissions allowed with this access token, white-space separated
        /// Example: AccountInfo CallLog ExtensionInfo Messages SMS
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        /// Type of token. The only possible value supported is Bearer. This value should be used when specifying access token in `Authorization` header of subsequent API requests
        /// Example: bearer
        /// </summary>
        public string token_type { get; set; }

        /// <summary>
        /// Extension identifier
        /// Example: 256440016
        /// </summary>
        public string owner_id { get; set; }

        /// <summary>
        /// Application instance identifier
        /// Example: 8zXq6oaLT7WvwWITlGiA1A
        /// </summary>
        public string endpoint_id { get; set; }

        /// <summary>
        /// </summary>
        public string id_token { get; set; }
    }
}