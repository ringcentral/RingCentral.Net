namespace RingCentral
{
    /// <summary>
    ///     The formula is defined by `aggregationType` and `aggregationInterval` for every counter individually. If
    ///     `aggregationType` is `Sum` or `Percent`, `aggregationInterval` is not supported. If `aggregationType` is `Min`,
    ///     `Max` or `Average`,`aggregationInterval` is required
    /// </summary>
    public class PerformanceCallsCountersResponseOptions
    {
        /// <summary>
        /// </summary>
        public PerformanceCallsCountersResponseOptionsAllCalls allCalls { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCountersResponseOptionsCallsByDirection callsByDirection { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCountersResponseOptionsCallsByOrigin callsByOrigin { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCountersResponseOptionsCallsByResponse callsByResponse { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCountersResponseOptionsCallsSegments callsSegments { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCountersResponseOptionsCallsByResult callsByResult { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCountersResponseOptionsCallsByCompanyHours callsByCompanyHours { get; set; }

        /// <summary>
        ///     This counter is only applicable to Queues grouping
        /// </summary>
        public PerformanceCallsCountersResponseOptionsCallsByQueueSla callsByQueueSla { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCountersResponseOptionsCallsByActions callsByActions { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCountersResponseOptionsCallsByType callsByType { get; set; }
    }
}