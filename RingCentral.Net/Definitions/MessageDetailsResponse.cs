namespace RingCentral
{
    // Detailed information on a message
    public class MessageDetailsResponse
    {
        /// <summary>
        /// Internal identifier of a message
        /// </summary>
        public string id;

        /// <summary>
        /// Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the message was sent
        /// </summary>
        public string from;

        /// <summary>
        /// List of phone numbers in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format to which the message was sent
        /// </summary>
        public string[] to;

        /// <summary>
        /// Text of a message
        /// </summary>
        public string text;

        /// <summary>
        /// Time at which the message is scheduled to be sent
        /// </summary>
        public string scheduledAt;

        /// <summary>
        /// Time when this message will not be attempted to be sent, returned if a message is scheduled or in the 'Queued' state
        /// </summary>
        public string expiresAt;

        /// <summary>
        /// Time of message creation
        /// </summary>
        public string createdAt;

        /// <summary>
        /// Time а a message last update
        /// </summary>
        public string lastUpdatedAt;

        /// <summary>
        /// Current status of a message
        /// Enum: Queued, Delivered, Sent, SendingFailed, DeliveryFailed
        /// </summary>
        public string messageStatus;

        /// <summary>
        /// Number of segments of a message
        /// </summary>
        public long? segmentCount;

        /// <summary>
        /// Cost of a message
        /// </summary>
        public decimal? cost;
    }
}