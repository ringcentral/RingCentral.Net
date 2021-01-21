namespace RingCentral
{
    public class TaskAssigneeInfo
    {
        /// <summary>
        /// Internal identifier of an assignee
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Status of the task execution by assignee
        /// Enum: Pending, Completed
        /// </summary>
        public string status { get; set; }
    }
}