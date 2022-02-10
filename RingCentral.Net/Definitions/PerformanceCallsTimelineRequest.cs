namespace RingCentral
{
    public class PerformanceCallsTimelineRequest
    {
        /// <summary>
        /// </summary>
        public PerformanceCallsGrouping grouping { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public PerformanceCallsTimeRange timeRange { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsAdditionalFilters additionalFilters { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public PerformanceCallsResponseDataOptions responseOptions { get; set; }
    }
}