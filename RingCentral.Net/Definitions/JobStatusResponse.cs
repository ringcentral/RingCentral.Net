namespace RingCentral
{
    public class JobStatusResponse
    {
        /// <summary>
        /// </summary>
        public string jobId { get; set; }

        /// <summary>
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Format: date-time
        /// </summary>
        public string completionTime { get; set; }

        /// <summary>
        ///     Format: date-time
        /// </summary>
        public string expirationTime { get; set; }

        /// <summary>
        ///     Enum: Success, Fail
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public JobStatusResponseResponse response { get; set; }
    }
}