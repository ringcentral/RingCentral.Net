namespace RingCentral
{
    /// <summary>
    ///     The formula is defined by `aggregationType` and `aggregationInterval` for every timer individually. If
    ///     `aggregationType` is `Sum` or `Percent`, `aggregationInterval` is not supported. If `aggregationType` is `Min`,
    ///     `Max` or `Average`,`aggregationInterval` is supported, but not required. If left empty, aggregation will be
    ///     performed on per-call basis
    /// </summary>
    public class PerformanceCallsTimersResponseOptions
    {
        /// <summary>
        /// </summary>
        public PerformanceCallsTimersResponseOptionsAllCallsDuration allCallsDuration { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimersResponseOptionsCallsDurationByDirection callsDurationByDirection { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimersResponseOptionsCallsDurationByOrigin callsDurationByOrigin { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimersResponseOptionsCallsDurationByResponse callsDurationByResponse { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimersResponseOptionsCallsSegmentsDuration callsSegmentsDuration { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimersResponseOptionsCallsDurationByResult callsDurationByResult { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimersResponseOptionsCallsDurationByCompanyHours callsDurationByCompanyHours
        {
            get;
            set;
        }

        /// <summary>
        ///     This timer is only applicable to Queues grouping
        /// </summary>
        public PerformanceCallsTimersResponseOptionsCallsDurationByQueueSla callsDurationByQueueSla { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimersResponseOptionsCallsDurationByType callsDurationByType { get; set; }
    }
}