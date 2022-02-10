namespace RingCentral
{
    public class PerformanceCallsAggregatesResponse
    {
        /// <summary>
        ///     Required
        /// </summary>
        public PerformanceCallsData[] data { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsPaging paging { get; set; }
    }
}