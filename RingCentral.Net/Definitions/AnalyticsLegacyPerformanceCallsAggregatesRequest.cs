namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsAggregatesRequest
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
        public AnalyticsLegacyPerformanceCallsResponseDataOptions responseOptions { get; set; }
    }
}