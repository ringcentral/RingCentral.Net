namespace RingCentral
{
    /// <summary>
    ///     Call length data for the specified grouping
    /// </summary>
    public class CallsTimers
    {
        /// <summary>
        /// </summary>
        public AllCalls allCalls { get; set; }

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
        public CallsBySegments callsSegments { get; set; }

        /// <summary>
        /// </summary>
        public CallsByResult callsByResult { get; set; }

        /// <summary>
        /// </summary>
        public CallsByCompanyHours callsByCompanyHours { get; set; }

        /// <summary>
        /// </summary>
        public CallsByQueueSla callsByQueueSla { get; set; }

        /// <summary>
        /// </summary>
        public CallsByType callsByType { get; set; }
    }
}