namespace RingCentral
{
    /// <summary>
    ///     Call length data for the specified grouping
    /// </summary>
    public class AnalyticsLegacyPerformanceCallsTimers
    {
        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTotal allCalls { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsByDirection callsByDirection { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsByOrigin callsByOrigin { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsByResponse callsByResponse { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsSegments callsSegments { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsByResult callsByResult { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsByCompanyHours callsByCompanyHours { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsByQueueSla callsByQueueSla { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsByType callsByType { get; set; }
    }
}