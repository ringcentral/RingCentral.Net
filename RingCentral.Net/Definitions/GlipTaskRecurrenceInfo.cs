namespace RingCentral
{
    public class GlipTaskRecurrenceInfo
    {
        /// <summary>
        /// Task recurrence settings. For non-periodic tasks the value is 'None'
        /// Enum: None, Daily, Weekdays, Weekly, Monthly, Yearly
        /// </summary>
        public string schedule { get; set; }

        /// <summary>
        /// Task ending condition
        /// Enum: None, Count, Date
        /// </summary>
        public string endingCondition { get; set; }

        /// <summary>
        /// Count of iterations of periodic tasks
        /// Maximum: 10
        /// Minimum: 1
        /// </summary>
        public long? endingAfter { get; set; }

        /// <summary>
        /// End date of periodic task
        /// Format: date-time
        /// </summary>
        public string endingOn { get; set; }
    }
}