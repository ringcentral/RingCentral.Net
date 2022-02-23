namespace RingCentral
{
    /// <summary>
    ///     Conditional aggregation of calls based on the time spent by specified mailbox(es) on call
    /// </summary>
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