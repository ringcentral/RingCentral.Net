namespace RingCentral
{
    // Information on a task for adding multiple contacts to multiple extensions
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
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Task status
        ///     Required
        ///     Enum: Accepted, InProgress, Completed, Failed
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Datetime of a task creation
        ///     Required
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Datetime of a task latest update
        ///     Required
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        /// </summary>
        public AddressBookBulkUploadTaskResult results { get; set; }
    }
}