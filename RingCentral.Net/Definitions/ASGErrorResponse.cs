namespace RingCentral
{
    /// <summary>
    ///     Error response
    /// </summary>
    public class ASGErrorResponse
    {
        /// <summary>
        ///     Error code
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        ///     Human-readable description of an error. Not suitable for end users
        ///     Example: AccountId 1234 is invalid
        /// </summary>
        public string description { get; set; }
    }
}