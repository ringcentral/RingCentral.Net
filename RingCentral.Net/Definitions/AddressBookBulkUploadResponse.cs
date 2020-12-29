namespace RingCentral
{
    // Information on a task for adding multiple contacts to multiple extensions
    public class AddressBookBulkUploadResponse
    {
        /// <summary>
        /// Internal identifier of a task
        /// Required
        /// </summary>
        public string id;

        /// <summary>
        /// Link for the task status retrieval
        /// Required
        /// </summary>
        public string uri;

        /// <summary>
        /// Task status
        /// Required
        /// Enum: Accepted, InProgress, Completed, Failed
        /// </summary>
        public string status;

        /// <summary>
        /// Datetime of a task creation
        /// Required
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Datetime of a task latest update
        /// Required
        /// </summary>
        public string lastModifiedTime;

        /// <summary>
        /// </summary>
        public AddressBookBulkUploadTaskResult results;
    }
}