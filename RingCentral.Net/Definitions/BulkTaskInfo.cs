namespace RingCentral
{
    public class BulkTaskInfo
    {
        /// <summary>
        /// Internal identifier of a task for multiple switches creation
        /// </summary>
        public string id;

        /// <summary>
        /// Status of a task
        /// Enum: Accepted, Failed
        /// </summary>
        public string status;

        /// <summary>
        /// Task creation time
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Time of the task latest modification
        /// </summary>
        public string lastModifiedTime;
    }
}