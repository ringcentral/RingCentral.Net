namespace RingCentral
{
    public class ValidationError
    {
        /// <summary>
        ///     Error code
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        ///     Error message
        /// </summary>
        public string message { get; set; }

        /// <summary>
        ///     Name of invalid parameter
        /// </summary>
        public string parameterName { get; set; }
    }
}