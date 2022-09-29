namespace RingCentral
{
    /// <summary>
    ///     This field provides mapping of possible breakdown options for call aggregation and aggregation formula
    /// </summary>
    public class AnalyticsLegacyPerformanceCallsResponseDataOptions
    {
        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsCountersResponseOptions counters { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTimersResponseOptions timers { get; set; }
    }
}