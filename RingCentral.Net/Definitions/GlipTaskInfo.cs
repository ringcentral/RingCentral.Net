namespace RingCentral
{
    public class GlipTaskInfo
    {
        /// <summary>
        ///     Internal identifier of a task
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Datetime of the task creation in UTC time zone.
        ///     Format: datetime
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Datetime of the last modification of the task in UTC time zone.
        ///     Format: datetime
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Type of a task
        ///     Enum: Task
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public GlipCreatorInfo creator { get; set; }

        /// <summary>
        ///     Chat IDs where the task is posted or shared.
        /// </summary>
        public string[] chatIds { get; set; }

        /// <summary>
        ///     Status of task execution
        ///     Enum: Pending, InProgress, Completed
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Name/subject of a task
        /// </summary>
        public string subject { get; set; }

        /// <summary>
        /// </summary>
        public TaskAssigneeInfo[] assignees { get; set; }

        /// <summary>
        ///     Specifies how to determine task completeness
        ///     Enum: Simple, AllAssignees, Percentage
        /// </summary>
        public string completenessCondition { get; set; }

        /// <summary>
        ///     Current completeness percentage of the task with the specified percentage completeness condition
        ///     Maximum: 100
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
        ///     Task section to group/search by
        /// </summary>
        public string section { get; set; }

        /// <summary>
        ///     Task details
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// </summary>
        public GlipTaskRecurrenceInfo recurrence { get; set; }

        /// <summary>
        /// </summary>
        public TaskAttachment[] attachments { get; set; }
    }
}