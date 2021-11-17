namespace RingCentral
{
    public class TimelineDataPoint
    {
        /// <summary>
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string time { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimers timers { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounters counters { get; set; }
    }
}