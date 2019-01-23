namespace RingCentral
{
    public class DataExportTask : Serializable
    {
        // Canonical URI of a task
        public string uri;

        // Internal identifier of a task
        public string id;

        // Task creation datetime
        public string creationTime;

        // Task last modification datetime
        public string lastModifiedTime;

        // Task status
        // Enum: Accepted, InProgress, Completed, Failed
        public string status;

        // Data collection archives. Returned by task ID
        public ExportTaskResultInfo[] result;
    }
}