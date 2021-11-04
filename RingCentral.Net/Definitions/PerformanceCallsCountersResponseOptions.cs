namespace RingCentral
{
    // Performance calls counters
    public class PerformanceCallsCountersResponseOptions
    {
        /// <summary>
        /// </summary>
        public PerformanceCallsCounter allCalls { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByDirection { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByOrigin { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByResponse { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByResponseType { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsBySegment { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByResult { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByActions { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByCompanyHours { get; set; }
    }
}