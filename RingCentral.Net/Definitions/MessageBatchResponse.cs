namespace RingCentral
{
    /// <summary>
    ///     Batch of A2P SMS messages. This object provides a specification
    ///     to send message(s) to many recipients. It contains top-level attributes which apply to all messages. In addition
    ///     to that, it is possible to override this attribute for each message. This
    ///     way a single API call may be used to send individual messages to many recipients
    /// </summary>
    public class MessageBatchResponse
    {
        /// <summary>
        ///     Unique identifier of the message batch
        ///     Example: 12345
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the messages are going to
        ///     be sent
        ///     Example: +15551234567
        /// </summary>
        public string from { get; set; }

        /// <summary>
        ///     Total number of messages in the accepted batch
        ///     Format: int32
        ///     Example: 5
        /// </summary>
        public long? batchSize { get; set; }

        /// <summary>
        ///     Total number of messages currently processed in the batch
        ///     Format: int32
        ///     Example: 1
        /// </summary>
        public long? processedCount { get; set; }

        /// <summary>
        ///     The last time the batch was processed.
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Current status of a message batch
        ///     Example: Processing
        ///     Enum: Processing, Completed
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     The time at which the batch was created
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     The list of rejected/invalid recipients
        /// </summary>
        public RejectedRecipientResponseResource[] rejected { get; set; }

        /// <summary>
        ///     The estimated batch cost for completed batch. Calculated after batch processing is completed.
        ///     Format: double
        ///     Example: 0.007
        /// </summary>
        public decimal? cost { get; set; }
    }
}