namespace RingCentral
{
    public class TokenInfo
    {
        /// <summary>
        ///     OAuth access token to pass to subsequent API requests
        ///     Required
        ///     Example: U1BCMDFUMDRKV1MwMXxzLFSvXdw5PHMsVLEn_MrtcyxUsw
        /// </summary>
        public string access_token { get; set; }

        /// <summary>
        ///     Issued access token TTL (time-to-live) in seconds
        ///     Required
        ///     Format: int32
        ///     Example: 7199
        /// </summary>
        public long? expires_in { get; set; }

        /// <summary>
        ///     OAuth refresh token (in case the one was issued)
        ///     Example: U1BCMDFUMDRKV1MwMXxzLFL4ec6A0XMsUv9wLriecyxS_w
        /// </summary>
        public string refresh_token { get; set; }

        /// <summary>
        ///     Issued refresh token TTL (time-to-live) in seconds
        ///     Format: int32
        ///     Example: 604799
        /// </summary>
        public long? refresh_token_expires_in { get; set; }

        /// <summary>
        ///     List of permissions (space separated) granted to the application with this access token
        ///     Required
        ///     Example: AccountInfo CallLog ExtensionInfo Messages SMS
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        ///     Type of token. The only supported value is `bearer`. This value should be used when specifying access token in
        ///     `Authorization` header of subsequent API requests
        ///     Required
        ///     Example: bearer
        /// </summary>
        public string token_type { get; set; }

        /// <summary>
        ///     Token owner (extension/user) identifier
        ///     Example: 256440016
        /// </summary>
        public string owner_id { get; set; }

        /// <summary>
        ///     Application instance identifier
        ///     Example: 8zXq6oaLT7WvwWITlGiA1A
        /// </summary>
        public string endpoint_id { get; set; }

        /// <summary>
        ///     OIDC ID token (if OpenId Connect flow was activated during authorization)
        /// </summary>
        public string id_token { get; set; }

        /// <summary>
        ///     OAuth session ID
        /// </summary>
        public string session_id { get; set; }

        /// <summary>
        ///     Absolute value of session expiration time as ISO datetime
        ///     Format: date-time
        /// </summary>
        public string session_expiration_time { get; set; }

        /// <summary>
        ///     Remaining time (in seconds) until session expiration due to absolute timeout
        ///     Format: int32
        /// </summary>
        public long? session_expires_in { get; set; }

        /// <summary>
        ///     Nominal session idle timeout in seconds
        ///     Format: int32
        /// </summary>
        public long? session_idle_timeout { get; set; }
    }
}