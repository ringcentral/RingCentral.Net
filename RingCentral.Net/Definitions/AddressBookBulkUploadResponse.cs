namespace RingCentral
{
    /// <summary>
    ///     Information on a task for adding multiple contacts to multiple extensions
    /// </summary>
    public class AddressBookBulkUploadResponse
    {
        /// <summary>
        ///     Internal identifier of a task
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link for the task status retrieval
        ///     Required
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Task status
        ///     Required
        ///     Enum: Accepted, InProgress, Completed, Failed
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Date/time of a task creation
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Date/time of a task latest update
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        /// </summary>
        public AddressBookBulkUploadTaskResult results { get; set; }
    }
}