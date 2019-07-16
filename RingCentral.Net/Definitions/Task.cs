namespace RingCentral
{
    public class Task
    {
        /// <summary>
        /// Internal identifier of a task
        /// </summary>
        public string id;

        /// <summary>
        /// Datetime of the task creation in UTC time zone.
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Datetime of the last modification of the task in UTC time zone.
        /// </summary>
        public string lastModifiedTime;

        /// <summary>
        /// Type of a task
        /// Enum: Task
        /// </summary>
        public string type;

        /// <summary>
        /// </summary>
        public object creator;

        /// <summary>
        /// Chat IDs where the task is posted or shared.
        /// </summary>
        public string[] chatIds;

        /// <summary>
        /// Status of task execution
        /// </summary>
        public string[] status;

        /// <summary>
        /// Name/subject of a task
        /// </summary>
        public string subject;

        /// <summary>
        /// Task name/subject
        /// </summary>
        public object[] assignees;

        /// <summary>
        /// Specifies how to determine task completeness
        /// Enum: Simple, AllAssignees, Percentage
        /// </summary>
        public string completenessCondition;

        /// <summary>
        /// Current completeness percentage of the task with the specified percentage completeness condition
        /// Maximum: 100
        /// </summary>
        public long? completenessPercentage;

        /// <summary>
        /// Task start date
        /// </summary>
        public string startDate;

        /// <summary>
        /// Task due date/time
        /// </summary>
        public string dueDate;

        /// <summary>
        /// Font color of a post with the current task
        /// Enum: Black, Red, Orange, Yellow, Green, Blue, Purple, Magenta
        /// </summary>
        public string color;

        /// <summary>
        /// Task section to group/search by
        /// </summary>
        public string section;

        /// <summary>
        /// Task details
        /// </summary>
        public string description;

        /// <summary>
        /// Task details
        /// </summary>
        public object recurrence;

        /// <summary>
        /// </summary>
        public TaskAttachment[] attachments;
    }
}