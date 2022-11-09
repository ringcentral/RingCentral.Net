namespace RingCentral
{
    /// <summary>
    ///     Options for selecting breakdown for calls count
    /// </summary>
    public class TimelineResponseOptionsCounters
    {
        /// <summary>
        ///     Include data for total calls count
        /// </summary>
        public bool? allCalls { get; set; }

        /// <summary>
        ///     Include breakdown of calls count by direction (Inbound, Outbound)
        /// </summary>
        public bool? callsByDirection { get; set; }

        /// <summary>
        ///     Include breakdown of calls count by origin (Internal, External)
        /// </summary>
        public bool? callsByOrigin { get; set; }

        /// <summary>
        ///     Include breakdown of calls count by response (Answered, NotAnswered, Connected, NotConnected)
        /// </summary>
        public bool? callsByResponse { get; set; }

        /// <summary>
        ///     Include breakdown of calls count by segments (Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, Voicemail,
        ///     VmGreeting, Setup)
        /// </summary>
        public bool? callsSegments { get; set; }

        /// <summary>
        ///     Include breakdown of calls count by result (Completed, Abandoned, Voicemail, Unknown, Missed, Accepted)
        /// </summary>
        public bool? callsByResult { get; set; }

        /// <summary>
        ///     Include breakdown of calls count by company hours (BusinessHours, AfterHours)
        /// </summary>
        public bool? callsByCompanyHours { get; set; }

        /// <summary>
        ///     Include breakdown of calls count by queue SLA (InSLA, OutSLA). This counter is only applicable to Queues grouping
        /// </summary>
        public bool? callsByQueueSla { get; set; }

        /// <summary>
        ///     Include breakdown of calls count by action (HoldOff, HoldOn, ParkOn, ParkOff, BlindTransfer, WarmTransfer,
        ///     DTMFTransfer)
        /// </summary>
        public bool? callsByActions { get; set; }

        /// <summary>
        ///     Include breakdown of calls count by type (Direct, FromQueue, ParkRetrieval, Transferred, Outbound)
        /// </summary>
        public bool? callsByType { get; set; }

        /// <summary>
        ///     Include breakdown of calls count by the total number of times a Queue call was presented to the user. It is limited
        ///     to `groupBy` Users and `groupByMembers` (Department, Queue, Site, UserGroup) grouping. Only the listed below
        ///     options for call filters are applicable to `queueOpportunities` and provide meaningful results: `queues` (selected
        ///     queue extension ids), `callResults` (Missed, Abandoned), `callResponses` (Answered, NotAnswered), `origins`
        ///     (Internal, External)
        /// </summary>
        public bool? queueOpportunities { get; set; }
    }
}