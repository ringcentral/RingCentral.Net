namespace RingCentral
{
    // Infomation on a message returned within the specified batch
    public class MessageListMessageResponse
    {
        /// <summary>
        /// Internal identifier of a message
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        /// Internal identifier of a batch the message was submitted in
        /// </summary>
        public string batchId { get; set; }

        /// <summary>
        /// Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the message is sent
        /// </summary>
        public string from { get; set; }

        /// <summary>
        /// Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format to which a message is sent
        /// </summary>
        public string[] to { get; set; }

        /// <summary>
        /// The time at which the message was created
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        /// The time at which the messages was last updated
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
        /// Text of a message. Returned if the `view` parameter is set to 'Detailed'
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Cost of a message
        /// </summary>
        public decimal? cost { get; set; }

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