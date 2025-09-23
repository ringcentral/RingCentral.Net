namespace RingCentral
{
    /// <summary>
    ///     Single (of potential multiple) error entry in an ASG error response
    /// </summary>
    public class ErrorEntry
    {
        /// <summary>
        ///     Error code
        ///     Required
        ///     Example: CMN-101
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        ///     Human-readable description of the error. Not suitable for end users.
        ///     Required
        ///     Example: AccountId 1234 is invalid
        /// </summary>
        public string message { get; set; }
    }
}