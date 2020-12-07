namespace RingCentral
{
    public class AutomaticLocationUpdatesTaskInfo
    {
        /// <summary>
        /// Internal identifier of a task
        /// </summary>
        public string id;

        /// <summary>
        /// Status of a task
        /// Enum: Accepted, InProgress, Completed, Failed
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

        /// <summary>
        /// Type of a task
        /// Enum: WirelessPointsBulkCreate, WirelessPointsBulkUpdate, SwitchesBulkCreate, SwitchesBulkUpdate
        /// </summary>
        public string type;

        /// <summary>
        /// </summary>
        public TaskResultInfo result;
    }
}