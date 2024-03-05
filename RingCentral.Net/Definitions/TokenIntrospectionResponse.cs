namespace RingCentral
{
    public class TokenIntrospectionResponse
    {
        /// <summary>
        ///     Is presented token valid and active
        ///     Required
        ///     Example: true
        /// </summary>
        public bool? active { get; set; }

        /// <summary>
        ///     List of permissions (space separated) granted to the application with this token
        ///     Example: AccountInfo CallLog ExtensionInfo Messages SMS
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        ///     Identifier (key) of a client application
        /// </summary>
        public string client_id { get; set; }

        /// <summary>
        ///     Type of token. The only supported value is `bearer`
        ///     Example: bearer
        /// </summary>
        public string token_type { get; set; }

        /// <summary>
        ///     Timestamp indicating when this token will expire in seconds since January 1 1970 UTC
        ///     Format: int64
        ///     Example: 1706715293
        /// </summary>
        public long? exp { get; set; }

        /// <summary>
        ///     Timestamp indicating when this token was originally issued in seconds since January 1 1970 UTC
        ///     Format: int64
        ///     Example: 1706711693
        /// </summary>
        public long? iat { get; set; }

        /// <summary>
        ///     Subject of the token (extension ID or the owner)
        /// </summary>
        public string sub { get; set; }

        /// <summary>
        ///     RC account ID associated with the token
        /// </summary>
        public string account_id { get; set; }

        /// <summary>
        ///     OAuth session ID associated with the token
        /// </summary>
        public string session_id { get; set; }
    }
}