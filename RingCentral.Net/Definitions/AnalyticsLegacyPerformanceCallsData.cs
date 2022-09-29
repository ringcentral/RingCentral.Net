namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsData
    {
        /// <summary>
        ///     Grouping key
        ///     Required
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyKeyInfo keyInfo { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTimers timers { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsCounters counters { get; set; }
    }
}