namespace RingCentral
{
    /// <summary>
    ///     Generalized API error structure suitable for any error type
    /// </summary>
    public class ApiErrorWithParameter
    {
        /// <summary>
        ///     Logical error code (typically, 3 letters followed with number, dash separated)
        ///     Required
        ///     Example: XXX-123
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        ///     User-friendly error message
        ///     Required
        ///     Example: Something went wrong
        /// </summary>
        public string message { get; set; }

        /// <summary>
        ///     The name of the API parameter/attribute which caused the error
        /// </summary>
        public string parameterName { get; set; }

        /// <summary>
        ///     The value of the API parameter/attribute which caused the error
        /// </summary>
        public string parameterValue { get; set; }
    }
}