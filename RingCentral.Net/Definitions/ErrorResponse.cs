namespace RingCentral
{
    // Error response
    public class ErrorResponse
    {
        /// <summary>
        ///     Error code
        ///     Example: CMN-101
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        ///     Human-readable description of the error. Not suitable for end users.
        ///     Example: AccountId 1234 is invalid
        /// </summary>
        public string description { get; set; }
    }
}