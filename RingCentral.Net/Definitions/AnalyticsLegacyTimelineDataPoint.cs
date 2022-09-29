namespace RingCentral
{
    public class AnalyticsLegacyTimelineDataPoint
    {
        /// <summary>
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string time { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTimers timers { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsCounters counters { get; set; }
    }
}