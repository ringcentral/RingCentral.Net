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
        ///     Task creation datetime
        ///     Required
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Task latest update datetime
        ///     Required
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionBulkUpdateTaskResult result { get; set; }
    }
}