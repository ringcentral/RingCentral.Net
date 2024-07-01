namespace RingCentral
{
    /// <summary>
    ///     Task information
    /// </summary>
    public class TaskRecurrenceInfo
    {
        /// <summary>
        ///     Recurrence settings of a task. None for non-periodic tasks
        ///     Default: None
        ///     Enum: None, Daily, Weekdays, Weekly, Monthly, Yearly
        /// </summary>
        public string schedule { get; set; }

        /// <summary>
        ///     Ending condition of a task
        ///     Default: None
        ///     Enum: None, Count, Date
        /// </summary>
        public string endingCondition { get; set; }

        /// <summary>
        ///     Count of iterations of periodic tasks
        ///     Maximum: 10
        ///     Minimum: 1
        ///     Format: int32
        /// </summary>
        public long? endingAfter { get; set; }

        /// <summary>
        ///     End date of a periodic task in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601)
        ///     format, UTC time zone
        ///     Format: date-time
        /// </summary>
        public string endingOn { get; set; }
    }
}