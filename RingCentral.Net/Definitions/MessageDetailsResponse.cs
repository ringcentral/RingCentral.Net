namespace RingCentral
{
    /// <summary>
    ///     Detailed information on a message
    /// </summary>
    public class MessageDetailsResponse
    {
        /// <summary>
        ///     Internal identifier of a message
        ///     Example: 1234
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the message was sent
        ///     Example: 15551234567
        /// </summary>
        public string from { get; set; }

        /// <summary>
        ///     List of phone numbers in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format to which the message was sent
        ///     Example: 15551234567
        /// </summary>
        public string[] to { get; set; }

        /// <summary>
        ///     Text of a message, maximum number of characters is 1000
        ///     Example: Hello, World!
        /// </summary>
        public string text { get; set; }

        /// <summary>
        ///     The time when this is message was created.
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     The time when this message was last updated.
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Current status of a message
        ///     Example: Queued
        ///     Enum: Queued, Delivered, Sent, SendingFailed, DeliveryFailed
        /// </summary>
        public string messageStatus { get; set; }

        /// <summary>
        ///     Number of segments of a message
        ///     Format: int32
        ///     Example: 1
        /// </summary>
        public long? segmentCount { get; set; }

        /// <summary>
        ///     Cost of a message
        ///     Format: double
        ///     Example: 0.007
        /// </summary>
        public decimal? cost { get; set; }

        /// <summary>
        ///     The batch in which the message was submitted
        ///     Example: batch12345
        /// </summary>
        public string batchId { get; set; }

        /// <summary>
        ///     Indicates whether the message is outbound or inbound
        ///     Example: out
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        ///     RC error code of the message sending failure reason
        ///     Example: SMS-RC-503
        /// </summary>
        public string errorCode { get; set; }
    }
}