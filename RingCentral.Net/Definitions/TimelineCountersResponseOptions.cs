namespace RingCentral
{
    public class TimelineCountersResponseOptions
    {
        /// <summary>
        /// </summary>
        public bool? allCalls { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsByDirection { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsByOrigin { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsByResponse { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsSegments { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsByResult { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsByCompanyHours { get; set; }

        /// <summary>
        ///     This counter is only applicable to Queues grouping
        /// </summary>
        public bool? callsByQueueSla { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsByActions { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsByType { get; set; }
    }
}