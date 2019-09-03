namespace RingCentral
{
    public class GlipCreateTask
    {
        /// <summary>
        /// Task name/subject. Max allowed length is 250 characters.
        /// Required
        /// </summary>
        public string subject;

        /// <summary>
        /// Required
        /// </summary>
        public object[] assignees;

        /// <summary>
        /// Default: Simple
        /// Enum: Simple, AllAssignees, Percentage
        /// </summary>
        public string completenessCondition;

        /// <summary>
        /// Task start date in UTC time zone.
        /// </summary>
        public string startDate;

        /// <summary>
        /// Task due date/time in UTC time zone.
        /// </summary>
        public string dueDate;

        /// <summary>
        /// Default: Black
        /// Enum: Black, Red, Orange, Yellow, Green, Blue, Purple, Magenta
        /// </summary>
        public string color;

        /// <summary>
        /// Task section to group / search by. Max allowed legth is 100 characters.
        /// </summary>
        public string section;

        /// <summary>
        /// Task details. Max allowed legth is 102400 characters (100kB).
        /// </summary>
        public string description;

        /// <summary>
        /// </summary>
        public GlipTaskRecurrenceInfo recurrence;

        /// <summary>
        /// </summary>
        public object[] attachments;
    }
}