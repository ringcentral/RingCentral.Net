namespace RingCentral
{
    public class LocationDeletionErrorInfo
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
        ///     Additional attribute for this error, for example `parameterName`
        /// </summary>
        public string additionalInfo { get; set; }
    }
}