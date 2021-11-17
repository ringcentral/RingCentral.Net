namespace RingCentral
{
    // Performance calls timers
    public class PerformanceCallsTimersResponseOptions
    {
        /// <summary>
        /// </summary>
        public PerformanceCallsTimer allCallsDuration { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsSegmentsDuration { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsDurationByDirection { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsDurationByOrigin { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsDurationByResponse { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsDurationByResponseType { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsDurationByResult { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsDurationByCompanyHours { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsDurationByQueueSla { get; set; }
    }
}