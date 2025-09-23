namespace RingCentral
{
    /// <summary>
    ///     Options for selecting breakdown for calls duration
    /// </summary>
    public class TimelineResponseOptionsTimers
    {
        /// <summary>
        ///     Include data for all calls duration
        /// </summary>
        public bool? allCallsDuration { get; set; }

        /// <summary>
        ///     Include breakdown of calls duration by direction (Inbound, Outbound)
        /// </summary>
        public bool? callsDurationByDirection { get; set; }

        /// <summary>
        ///     Include breakdown of calls duration by origin (Internal, External)
        /// </summary>
        public bool? callsDurationByOrigin { get; set; }

        /// <summary>
        ///     Include breakdown of calls duration by response (Answered, NotAnswered, Connected, NotConnected)
        /// </summary>
        public bool? callsDurationByResponse { get; set; }

        /// <summary>
        ///     Include breakdown of calls duration by segments (Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, Voicemail,
        ///     VmGreeting, Setup)
        /// </summary>
        public bool? callsSegmentsDuration { get; set; }

        /// <summary>
        ///     Include breakdown of calls duration by result (Completed, Abandoned, Voicemail, Unknown, Missed, Accepted)
        /// </summary>
        public bool? callsDurationByResult { get; set; }

        /// <summary>
        ///     Include breakdown of calls duration by party that ended the call (Caller, Callee, System)
        /// </summary>
        public bool? callsDurationByEndingParty { get; set; }

        /// <summary>
        ///     Include breakdown of calls duration by company hours (BusinessHours, AfterHours)
        /// </summary>
        public bool? callsDurationByCompanyHours { get; set; }

        /// <summary>
        ///     Include breakdown of calls duration by queue SLA (InSLA, OutSLA). This timer is only applicable to Queues grouping
        /// </summary>
        public bool? callsDurationByQueueSla { get; set; }

        /// <summary>
        ///     Include breakdown of calls duration by type (Direct, FromQueue, ParkRetrieval, Transferred, Outbound)
        /// </summary>
        public bool? callsDurationByType { get; set; }

        /// <summary>
        ///     Include breakdown of calls duration by queue hours (BusinessHours, AfterHours)
        /// </summary>
        public bool? callsDurationByQueueHours { get; set; }
    }
}