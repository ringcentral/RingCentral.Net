namespace RingCentral
{
    public class BulkTaskInfo
    {
        /// <summary>
        ///     Internal identifier of a task for multiple switches creation
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Status of a task
        ///     Enum: Accepted, Failed
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Task creation time
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Time of the task latest modification
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }
    }
}