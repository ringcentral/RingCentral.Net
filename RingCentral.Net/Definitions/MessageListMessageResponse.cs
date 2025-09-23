namespace RingCentral
{
    /// <summary>
    ///     The short detail of the message in the get batch response
    /// </summary>
    public class MessageListMessageResponse
    {
        /// <summary>
        ///     The Id of the message
        ///     Format: int64
        ///     Example: 1234
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Internal identifier of a batch the message was submitted in
        ///     Example: 12345
        /// </summary>
        public string batchId { get; set; }

        /// <summary>
        ///     Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the message is sent
        ///     Example: +15551234567
        /// </summary>
        public string from { get; set; }

        /// <summary>
        ///     Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format to which a message is sent
        ///     Example: +15551234567
        /// </summary>
        public string[] to { get; set; }

        /// <summary>
        ///     The time at which the message was created
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     The time at which the message was last updated
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Status of the message
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
        ///     Text of a message. Returned if the `view` parameter is set to `Detailed`
        /// </summary>
        public string text { get; set; }

        /// <summary>
        ///     Cost of a message
        ///     Format: double
        ///     Example: 0.007
        /// </summary>
        public decimal? cost { get; set; }

        /// <summary>
        ///     Message direction (inbound or outbound)
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        ///     The RC error code of the message sending failure reason
        ///     Example: SMS-RC-503
        /// </summary>
        public string errorCode { get; set; }
    }
}