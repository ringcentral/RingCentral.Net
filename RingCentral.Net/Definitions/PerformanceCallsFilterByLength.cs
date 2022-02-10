namespace RingCentral
{
    /// <summary>
    ///     Conditional aggregation of calls based on the overall call length
    /// </summary>
    public class PerformanceCallsFilterByLength
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