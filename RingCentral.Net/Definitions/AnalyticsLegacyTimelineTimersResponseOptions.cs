namespace RingCentral
{
    public class AnalyticsLegacyTimelineTimersResponseOptions
    {
        /// <summary>
        /// </summary>
        public bool? allCallsDuration { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsDurationByDirection { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsDurationByOrigin { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsDurationByResponse { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsSegmentsDuration { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsDurationByResult { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsDurationByCompanyHours { get; set; }

        /// <summary>
        ///     This timer is only applicable to Queues grouping
        /// </summary>
        public bool? callsDurationByQueueSla { get; set; }

        /// <summary>
        /// </summary>
        public bool? callsDurationByType { get; set; }
    }
}