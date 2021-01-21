namespace RingCentral
{
    // Detailed information on a message
    public class MessageDetailsResponse
    {
        /// <summary>
        /// Internal identifier of a message
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the message was sent
        /// </summary>
        public string from { get; set; }

        /// <summary>
        /// List of phone numbers in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format to which the message was sent
        /// </summary>
        public string[] to { get; set; }

        /// <summary>
        /// Text of a message, maximum number of characters is 1000
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// The time when this is message was created.
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        /// The time when this message was last updated.
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        /// Current status of a message
        /// Enum: Queued, Delivered, Sent, SendingFailed, DeliveryFailed
        /// </summary>
        public string messageStatus { get; set; }

        /// <summary>
        /// Number of segments of a message
        /// </summary>
        public long? segmentCount { get; set; }

        /// <summary>
        /// Cost of a message
        /// </summary>
        public decimal? cost { get; set; }

        /// <summary>
        /// The batchId in which the message was submitted
        /// </summary>
        public string batchId { get; set; }

        /// <summary>
        /// Indicates whether the message was outbound or inbound
        /// Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        /// The RC error code of the message sending failure reason
        /// </summary>
        public string errorCode { get; set; }
    }
}