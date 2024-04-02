namespace RingCentral
{
    public class TMTaskInfoRecurrence
    {
        /// <summary>
        ///     Task recurrence settings. None for non-periodic tasks
        ///     Enum: None, Daily, Weekdays, Weekly, Monthly, Yearly
        /// </summary>
        public string schedule { get; set; }

        /// <summary>
        ///     Task ending condition
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
        ///     End date of a periodic task in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        ///     Format: date-time
        /// </summary>
        public string endingOn { get; set; }
    }
}