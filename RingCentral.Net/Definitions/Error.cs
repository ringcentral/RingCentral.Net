namespace RingCentral
{
    public class Error
    {
        /// <summary>
        ///     Logical error code
        ///     Required
        ///     Example: XYZ-123
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        ///     User-friendly error message
        ///     Required
        ///     Example: Something went wrong
        /// </summary>
        public string message { get; set; }

        /// <summary>
        ///     The name of the request parameter or attribute that caused the error
        ///     Example: accountId
        /// </summary>
        public string parameterName { get; set; }
    }
}