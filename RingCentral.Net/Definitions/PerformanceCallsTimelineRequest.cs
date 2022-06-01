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
        public PerformanceCallsTimeSettings timeSettings { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsFilters additionalFilters { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public TimelineResponseDataOptions responseOptions { get; set; }
    }
}