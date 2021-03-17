namespace RingCentral
{
    // Information about the message that failed to be sent
    public class RejectedMessageInfo
    {
        /// <summary>
        /// Index of the rejected message in the request
        /// </summary>
        public long? index { get; set; }

        /// <summary>
        /// </summary>
        public string[] to { get; set; }

        /// <summary>
        /// Standard error code
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        /// Standard error description
        /// </summary>
        public string description { get; set; }
    }
}