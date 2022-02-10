namespace RingCentral
{
    /// <summary>
    ///     Information about the message that failed to be sent
    /// </summary>
    public class RejectedMessageInfo
    {
        /// <summary>
        ///     Index of the rejected message in the request
        ///     Format: int32
        ///     Example: 2
        /// </summary>
        public long? index { get; set; }

        /// <summary>
        /// </summary>
        public string[] to { get; set; }

        /// <summary>
        ///     Standard error code
        ///     Example: CMN-100
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        ///     Standard error description
        ///     Example: Parameter [to] value is invalid
        /// </summary>
        public string description { get; set; }
    }
}