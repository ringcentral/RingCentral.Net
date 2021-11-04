namespace RingCentral
{
    // Call length data for the specified grouping.
    public class PerformanceCallsTimers
    {
        /// <summary>
        ///     Format: int64
        /// </summary>
        public long? callsDurationSeconds { get; set; }

        /// <summary>
        /// </summary>
        public TimeSpentBySegments callSegmentLengthSeconds { get; set; }

        /// <summary>
        /// </summary>
        public CallsDurationByDirection callsByDirection { get; set; }

        /// <summary>
        /// </summary>
        public CallsDurationByOrigin callsByOrigin { get; set; }

        /// <summary>
        /// </summary>
        public CallDurationByResponse callsByResponse { get; set; }

        /// <summary>
        /// </summary>
        public CallDurationByResult callsByResult { get; set; }

        /// <summary>
        /// </summary>
        public CallDurationByResponseType callsByResponseType { get; set; }

        /// <summary>
        /// </summary>
        public CallDurationByCompanyHours callsByCompanyHours { get; set; }
    }
}