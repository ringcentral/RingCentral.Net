namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsTimelineRequest
    {
        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsGrouping grouping { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTimeSettings timeSettings { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsFilters additionalFilters { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AnalyticsLegacyTimelineResponseDataOptions responseOptions { get; set; }
    }
}