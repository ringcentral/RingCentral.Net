namespace RingCentral
{
    // Call volume data for the specified grouping.
    public class PerformanceCallsCounters
    {
        /// <summary>
        ///     Format: int64
        /// </summary>
        public long? totalCalls { get; set; }

        /// <summary>
        /// </summary>
        public CallsByDirection callsByDirection { get; set; }

        /// <summary>
        /// </summary>
        public CallsByOrigin callsByOrigin { get; set; }

        /// <summary>
        /// </summary>
        public CallsByResponse callsByResponse { get; set; }

        /// <summary>
        /// </summary>
        public CallsByResponseType callsByResponseType { get; set; }

        /// <summary>
        /// </summary>
        public CallsByResult callsByResult { get; set; }

        /// <summary>
        /// </summary>
        public CallsActionsCount callsActionsCount { get; set; }

        /// <summary>
        /// </summary>
        public CallsBySegments callsBySegments { get; set; }

        /// <summary>
        /// </summary>
        public CallsByCompanyHours callsByCompanyHours { get; set; }
    }
}