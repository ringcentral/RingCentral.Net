namespace RingCentral
{
    /// <summary>
    ///     Call length data for the specified grouping.
    /// </summary>
    public class PerformanceCallsTimers
    {
        /// <summary>
        /// </summary>
        public PerformanceCallsTotal allCalls { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsByDirection callsByDirection { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsByOrigin callsByOrigin { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsByResponse callsByResponse { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsSegments callsSegments { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsByResult callsByResult { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsByCompanyHours callsByCompanyHours { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsByQueueSla callsByQueueSla { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsByType callsByType { get; set; }
    }
}