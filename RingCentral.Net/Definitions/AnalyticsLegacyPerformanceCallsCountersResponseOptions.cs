namespace RingCentral
{
    /// <summary>
    ///     The formula is defined by `aggregationType` and `aggregationInterval` for every counter individually.
    ///     If `aggregationType` is `Sum` or `Percent`, `aggregationInterval` is not supported.
    ///     If `aggregationType` is `Min`, `Max` or `Average`, `aggregationInterval` is required
    /// </summary>
    public class AnalyticsLegacyPerformanceCallsCountersResponseOptions
    {
        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsCountersResponseOptionsAllCalls allCalls { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsCountersResponseOptionsCallsByDirection callsByDirection { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsCountersResponseOptionsCallsByOrigin callsByOrigin { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsCountersResponseOptionsCallsByResponse callsByResponse { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsCountersResponseOptionsCallsSegments callsSegments { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsCountersResponseOptionsCallsByResult callsByResult { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsCountersResponseOptionsCallsByCompanyHours callsByCompanyHours
        {
            get;
            set;
        }

        /// <summary>
        ///     This counter is only applicable to Queues grouping
        /// </summary>
        public AnalyticsLegacyPerformanceCallsCountersResponseOptionsCallsByQueueSla callsByQueueSla { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsCountersResponseOptionsCallsByActions callsByActions { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsCountersResponseOptionsCallsByType callsByType { get; set; }
    }
}