namespace RingCentral
{
    public class TMTaskInfo
    {
        /// <summary>
        ///     Internal identifier of a task
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Task creation date/time in UTC time zone
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Task the last modified time in UTC time zone
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Task type
        ///     Enum: Task
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public TMTaskInfoCreator creator { get; set; }

        /// <summary>
        ///     Internal identifiers of the chats where the task is posted or shared
        /// </summary>
        public string[] chatIds { get; set; }

        /// <summary>
        ///     Task execution status
        ///     Enum: Pending, InProgress, Completed
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Task name/subject
        /// </summary>
        public string subject { get; set; }

        /// <summary>
        ///     Task name/subject
        /// </summary>
        public TMTaskInfoAssignees[] assignees { get; set; }

        /// <summary>
        ///     How the task completeness should be determined
        ///     Enum: Simple, AllAssignees, Percentage
        /// </summary>
        public string completenessCondition { get; set; }

        /// <summary>
        ///     Current completeness percentage of the task with the specified percentage completeness condition
        ///     Maximum: 100
        ///     Format: int32
        /// </summary>
        public long? completenessPercentage { get; set; }

        /// <summary>
        ///     Task start date
        ///     Format: date-time
        /// </summary>
        public string startDate { get; set; }

        /// <summary>
        ///     Task due date/time
        ///     Format: date-time
        /// </summary>
        public string dueDate { get; set; }

        /// <summary>
        ///     Font color of a post with the current task
        ///     Enum: Black, Red, Orange, Yellow, Green, Blue, Purple, Magenta
        /// </summary>
        public string color { get; set; }

        /// <summary>
        ///     Task section to group / search by
        /// </summary>
        public string section { get; set; }

        /// <summary>
        ///     Task details
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Task details.
        /// </summary>
        public TMTaskInfoRecurrence recurrence { get; set; }

        /// <summary>
        /// </summary>
        public TaskAttachment[] attachments { get; set; }
    }
}