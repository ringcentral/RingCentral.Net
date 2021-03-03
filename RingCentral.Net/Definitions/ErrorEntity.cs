namespace RingCentral
{
    public class ErrorEntity
    {
        /// <summary>
        /// Error code
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// Name of invalid parameter
        /// </summary>
        public string parameterName { get; set; }

        /// <summary>
        /// Value of invalid parameter
        /// </summary>
        public string parameterValue { get; set; }
    }
}