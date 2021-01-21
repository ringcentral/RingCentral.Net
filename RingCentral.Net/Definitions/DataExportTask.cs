namespace RingCentral
{
    public class DataExportTask
    {
        /// <summary>
        /// Canonical URI of a task
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Internal identifier of a task
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Task creation datetime
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        /// Task last modification datetime
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        /// Task status
        /// Enum: Accepted, InProgress, Completed, Failed, Expired
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public CreatorInfo creator { get; set; }

        /// <summary>
        /// </summary>
        public SpecificInfo specific { get; set; }

        /// <summary>
        /// Data collection sets. Returned by task ID
        /// </summary>
        public ExportTaskResultInfo[] datasets { get; set; }
    }
}