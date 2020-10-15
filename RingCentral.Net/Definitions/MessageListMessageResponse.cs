namespace RingCentral
{
    // Infommation on a message returned within the specified batch
    public class MessageListMessageResponse
    {
        /// <summary>
        /// Internal identifier of a message
        /// </summary>
        public long? id;

        /// <summary>
        /// Internal identifier of a batch the message was submitted in
        /// </summary>
        public string batchId;

        /// <summary>
        /// Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the message is sent
        /// </summary>
        public string from;

        /// <summary>
        /// Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format to which a message is sent
        /// </summary>
        public string[] to;

        /// <summary>
        /// Time of message creation
        /// </summary>
        public string createdAt;

        /// <summary>
        /// Time of the message(s) last update
        /// </summary>
        public string lastUpdatedAt;

        /// <summary>
        /// Current status of a message
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