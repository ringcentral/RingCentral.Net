namespace RingCentral
{
    /// <summary>
    ///     The rejected recipient details
    /// </summary>
    public class RejectedRecipientResponseResource
    {
        /// <summary>
        ///     The index of the messages list in the send batch request where the invalid recipient was found
        ///     Format: int64
        ///     Example: 1
        /// </summary>
        public long? index { get; set; }

        /// <summary>
        ///     The invalid recipient number as found in the request
        ///     Example: 29395
        /// </summary>
        public string[] to { get; set; }

        /// <summary>
        ///     The error code
        ///     Example: CMN-100
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        ///     The description of the error
        ///     Example: The recipient is invalid
        /// </summary>
        public string description { get; set; }
    }
}