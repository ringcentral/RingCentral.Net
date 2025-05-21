namespace RingCentral
{
    /// <summary>
    ///     The formula is defined by `aggregationType` and `aggregationInterval` for every timer individually.
    ///     If `aggregationType` is `Sum` or `Percent`, `aggregationInterval` is not supported.
    ///     If `aggregationType` is `Min`, `Max` or `Average`, `aggregationInterval` is supported, but not required.
    ///     If left empty, aggregation will be performed on per-call basis
    /// </summary>
    public class AggregationResponseOptionsTimers
    {
        /// <summary>
        ///     Aggregation of all calls duration
        /// </summary>
        public AggregationResponseOptionsTimersAllCallsDuration allCallsDuration { get; set; }

        /// <summary>
        ///     Aggregation of calls duration by direction (Inbound, Outbound)
        /// </summary>
        public AggregationResponseOptionsTimersCallsDurationByDirection callsDurationByDirection { get; set; }

        /// <summary>
        ///     Aggregation of calls duration by origin (Internal, External)
        /// </summary>
        public AggregationResponseOptionsTimersCallsDurationByOrigin callsDurationByOrigin { get; set; }

        /// <summary>
        ///     Aggregation of calls duration by response (Answered, NotAnswered, Connected, NotConnected)
        /// </summary>
        public AggregationResponseOptionsTimersCallsDurationByResponse callsDurationByResponse { get; set; }

        /// <summary>
        ///     Aggregation of calls duration by segments (Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, Voicemail,
        ///     VmGreeting, Setup)
        /// </summary>
        public AggregationResponseOptionsTimersCallsSegmentsDuration callsSegmentsDuration { get; set; }

        /// <summary>
        ///     Aggregation of calls duration by result (Completed, Abandoned, Voicemail, Unknown, Missed, Accepted, Transferred,
        ///     PickedUp, AnsweredElsewhere)
        /// </summary>
        public AggregationResponseOptionsTimersCallsDurationByResult callsDurationByResult { get; set; }

        /// <summary>
        ///     Aggregation of calls duration by company hours (BusinessHours, AfterHours)
        /// </summary>
        public AggregationResponseOptionsTimersCallsDurationByCompanyHours callsDurationByCompanyHours { get; set; }

        /// <summary>
        ///     Aggregation of calls duration by queue SLA (InSLA, OutSLA). This timer is only applicable to Queues grouping
        /// </summary>
        public AggregationResponseOptionsTimersCallsDurationByQueueSla callsDurationByQueueSla { get; set; }

        /// <summary>
        ///     Aggregation of calls duration by type (Direct, FromQueue, ParkRetrieval, Transferred, Outbound, QueueCallPickup)
        /// </summary>
        public AggregationResponseOptionsTimersCallsDurationByType callsDurationByType { get; set; }

        /// <summary>
        ///     Aggregation of calls duration by party that ended the call (Callee, Caller, System)
        /// </summary>
        public AggregationResponseOptionsTimersCallsDurationByEndingParty callsDurationByEndingParty { get; set; }
    }
}