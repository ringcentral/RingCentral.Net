namespace RingCentral
{
    /// <summary>
    ///     This field provides mapping of possible breakdown options that will be used for aggregation within every time
    ///     interval
    /// </summary>
    public class AnalyticsLegacyTimelineResponseDataOptions
    {
        /// <summary>
        /// </summary>
        public AnalyticsLegacyTimelineCountersResponseOptions counters { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyTimelineTimersResponseOptions timers { get; set; }
    }
}