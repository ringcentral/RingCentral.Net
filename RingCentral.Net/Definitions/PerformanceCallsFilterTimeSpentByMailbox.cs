namespace RingCentral
{
    // Conditional aggregation of calls based on the time spent on a call by the specified mailbox(es)
    public class PerformanceCallsFilterTimeSpentByMailbox
    {
        /// <summary>
        ///     Format: int64
        /// </summary>
        public long? minValueSeconds { get; set; }

        /// <summary>
        ///     Format: int64
        /// </summary>
        public long? maxValueSeconds { get; set; }
    }
}