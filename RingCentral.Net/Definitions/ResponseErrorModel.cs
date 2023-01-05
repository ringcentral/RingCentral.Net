namespace RingCentral
{
    public class ResponseErrorModel
    {
        /// <summary>
        ///     Logical error code (typically, 3 letters followed with number, dash separated)
        ///     Example: XXX-123
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        ///     User-friendly error message
        ///     Example: Something went wrong
        /// </summary>
        public string message { get; set; }

        /// <summary>
        ///     The name of the API parameter which caused the error
        ///     Example: status
        /// </summary>
        public string parameterName { get; set; }
    }
}