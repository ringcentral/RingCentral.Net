namespace RingCentral
{
    // Information on the task for multiple wireless points update
    public class BulkTaskInfoWiUpdate
    {
        /// <summary>
        /// Internal identifier of a task for multiple switches creation
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Status of a task
        /// Enum: Accepted, Failed
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// Task creation time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        /// Time of the task latest modification
        /// </summary>
        public string lastModifiedTime { get; set; }
    }
}