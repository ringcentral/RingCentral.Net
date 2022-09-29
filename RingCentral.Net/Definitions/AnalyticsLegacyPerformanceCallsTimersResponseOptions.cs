namespace RingCentral
{
    /// <summary>
    ///     The formula is defined by `aggregationType` and `aggregationInterval` for every timer individually.
    ///     If `aggregationType` is `Sum` or `Percent`, `aggregationInterval` is not supported.
    ///     If `aggregationType` is `Min`, `Max` or `Average`, `aggregationInterval` is supported, but not required.
    ///     If left empty, aggregation will be performed on per-call basis
    /// </summary>
    public class AnalyticsLegacyPerformanceCallsTimersResponseOptions
    {
        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTimersResponseOptionsAllCallsDuration allCallsDuration { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTimersResponseOptionsCallsDurationByDirection callsDurationByDirection
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTimersResponseOptionsCallsDurationByOrigin callsDurationByOrigin
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTimersResponseOptionsCallsDurationByResponse callsDurationByResponse
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTimersResponseOptionsCallsSegmentsDuration callsSegmentsDuration
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTimersResponseOptionsCallsDurationByResult callsDurationByResult
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTimersResponseOptionsCallsDurationByCompanyHours
            callsDurationByCompanyHours { get; set; }

        /// <summary>
        ///     This timer is only applicable to Queues grouping
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTimersResponseOptionsCallsDurationByQueueSla callsDurationByQueueSla
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTimersResponseOptionsCallsDurationByType callsDurationByType { get; set; }
    }
}