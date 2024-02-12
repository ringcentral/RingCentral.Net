namespace RingCentral
{
    /// <summary>
    ///     Information on a task for updating multiple extensions
    /// </summary>
    public class ExtensionBulkUpdateTaskResource
    {
        /// <summary>
        ///     Link to a task resource
        ///     Required
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a task
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Task status
        ///     Required
        ///     Enum: Accepted, InProgress, Completed, Failed
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Task creation date/time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Task latest update date/time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionBulkUpdateTaskResult result { get; set; }
    }
}