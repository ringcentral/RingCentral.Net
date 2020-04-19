namespace RingCentral
{
    public class DataExportTask
    {
        /// <summary>
        /// Canonical URI of a task
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of a task
        /// </summary>
        public string id;

        /// <summary>
        /// Task creation datetime
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Task last modification datetime
        /// </summary>
        public string lastModifiedTime;

        /// <summary>
        /// Task status
        /// Enum: Accepted, InProgress, Completed, Failed, Canceled, Expired
        /// </summary>
        public string status;

        /// <summary>
        /// Internal identifier of a user
        /// </summary>
        public CreatorInfo creator;

        /// <summary>
        /// Information specififed in request
        /// </summary>
        public SpecificInfo specific;

        /// <summary>
        /// Data collection sets. Returned by task ID
        /// </summary>
        public ExportTaskResultInfo[] datasets;
    }
}