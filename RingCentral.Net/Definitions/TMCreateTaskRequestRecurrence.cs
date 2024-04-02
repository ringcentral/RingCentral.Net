namespace RingCentral
{
    public class TMCreateTaskRequestRecurrence
    {
        /// <summary>
        ///     Task recurrence settings.
        ///     Default: None
        ///     Enum: None, Daily, Weekdays, Weekly, Monthly, Yearly
        /// </summary>
        public string schedule { get; set; }

        /// <summary>
        ///     Task ending condition.
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
        ///     End date of a periodic task in UTC time zone
        ///     Format: date-time
        /// </summary>
        public string endingOn { get; set; }
    }
}