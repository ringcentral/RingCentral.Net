namespace RingCentral
{
    public class PerformanceCallsAggregatesRequest
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
        public PerformanceCallsFilters additionalFilters { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public PerformanceCallsResponseDataOptions responseOptions { get; set; }
    }
}