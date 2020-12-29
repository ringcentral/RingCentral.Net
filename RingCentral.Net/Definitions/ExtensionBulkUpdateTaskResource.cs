namespace RingCentral
{
    // Information on a task for updating multiple extensions
    public class ExtensionBulkUpdateTaskResource
    {
        /// <summary>
        /// Link to a task resource
        /// Required
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of a task
        /// Required
        /// </summary>
        public string id;

        /// <summary>
        /// Task status
        /// Required
        /// Enum: Accepted, InProgress, Completed, Failed
        /// </summary>
        public string status;

        /// <summary>
        /// Task creation datetime
        /// Required
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Task latest update datetime
        /// Required
        /// </summary>
        public string lastModifiedTime;

        /// <summary>
        /// </summary>
        public ExtensionBulkUpdateTaskResult result;
    }
}