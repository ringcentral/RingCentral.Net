namespace RingCentral
{
    public class SessionInfoResponse
    {
        /// <summary>
        ///     Identifier (key) of a client application
        ///     Required
        /// </summary>
        public string client_id { get; set; }

        /// <summary>
        ///     List of permissions (space separated) granted to the application with this token
        ///     Example: AccountInfo CallLog ExtensionInfo Messages SMS
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        ///     Subject of the token (extension ID or the owner)
        /// </summary>
        public string sub { get; set; }

        /// <summary>
        ///     RC account ID associated with the token
        /// </summary>
        public string account_id { get; set; }

        /// <summary>
        ///     Remaining time in seconds until session expiration due to absolute timeout
        ///     Format: int32
        /// </summary>
        public long? session_expires_in { get; set; }

        /// <summary>
        ///     Absolute value of session expiration time in ISO date formatted string
        ///     Format: date-time
        ///     Example: 2023-04-01T12:00:01Z
        /// </summary>
        public string session_expiration_time { get; set; }

        /// <summary>
        ///     OAuth session ID
        ///     Required
        /// </summary>
        public string session_id { get; set; }

        /// <summary>
        ///     Nominal value of session idle timeout in seconds
        ///     Format: int32
        /// </summary>
        public long? session_idle_timeout { get; set; }
    }
}