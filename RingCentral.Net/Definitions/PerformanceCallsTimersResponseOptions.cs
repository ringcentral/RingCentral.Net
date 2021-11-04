namespace RingCentral
{
    // Performance calls timers
    public class PerformanceCallsTimersResponseOptions
    {
        /// <summary>
        /// </summary>
        public PerformanceCallsTimer totalCallLength { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer timeSpentByCallSegments { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callLengthByDirection { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callLengthByOrigin { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callLengthByResponse { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callLengthByResponseType { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callLengthByResult { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsLengthByCompanyHours { get; set; }
    }
}