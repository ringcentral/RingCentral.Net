namespace RingCentral
{
    public class PerformanceCallsAggregatesRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public AggregatePerformanceCallsGrouping grouping { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public PerformanceCallsTimeSettings timeSettings { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsFilters additionalFilters { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public PerformanceCallsResponseDataOptions responseOptions { get; set; }
    }
}