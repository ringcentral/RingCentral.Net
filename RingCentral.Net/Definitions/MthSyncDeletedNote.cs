namespace RingCentral
{
    public class MthSyncDeletedNote
    {
        /// <summary>
        ///     Required
        ///     Enum: DeletedNote
        /// </summary>
        public string recordType { get; set; }

        /// <summary>
        ///     Internal identifier of a note
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Internal identifier of a message thread
        ///     Required
        /// </summary>
        public string threadId { get; set; }

        /// <summary>
        ///     Note availability status
        ///     Required
        ///     Enum: Deleted
        /// </summary>
        public string availability { get; set; }

        /// <summary>
        ///     Note last modification date/time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }
    }
}