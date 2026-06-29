namespace RingCentral
{
    public class MthSyncDeletedMessage
    {
        /// <summary>
        ///     Required
        ///     Enum: DeletedMessage
        /// </summary>
        public string recordType { get; set; }

        /// <summary>
        ///     Internal identifier of a message
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Internal identifier of a message thread
        ///     Required
        /// </summary>
        public string threadId { get; set; }

        /// <summary>
        ///     Message availability status
        ///     Required
        ///     Enum: Deleted
        /// </summary>
        public string availability { get; set; }

        /// <summary>
        ///     Message last modification date/time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }
    }
}