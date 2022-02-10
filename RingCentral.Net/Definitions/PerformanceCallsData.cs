namespace RingCentral
{
    /// <summary>
    ///     A list of call aggregations as per the grouping and filtering options specified in the request.
    /// </summary>
    public class PerformanceCallsData
    {
        /// <summary>
        ///     Grouping key
        ///     Required
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsKeyInfo keyInfo { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimers timers { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounters counters { get; set; }
    }
}