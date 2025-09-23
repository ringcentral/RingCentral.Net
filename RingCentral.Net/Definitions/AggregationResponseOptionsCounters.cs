namespace RingCentral
{
    /// <summary>
    ///     The formula is defined by `aggregationType` and `aggregationInterval` for every counter individually.
    ///     If `aggregationType` is `Sum` or `Percent`, `aggregationInterval` is not supported.
    ///     If `aggregationType` is `Min`, `Max` or `Average`, `aggregationInterval` is required
    /// </summary>
    public class AggregationResponseOptionsCounters
    {
        /// <summary>
        ///     Aggregation of all calls count
        /// </summary>
        public AggregationResponseOptionsCountersAllCalls allCalls { get; set; }

        /// <summary>
        ///     Aggregation of calls count by direction (Inbound, Outbound)
        /// </summary>
        public AggregationResponseOptionsCountersCallsByDirection callsByDirection { get; set; }

        /// <summary>
        ///     Aggregation of calls count by origin (Internal, External)
        /// </summary>
        public AggregationResponseOptionsCountersCallsByOrigin callsByOrigin { get; set; }

        /// <summary>
        ///     Aggregation of calls count by response (Answered, NotAnswered, Connected, NotConnected)
        /// </summary>
        public AggregationResponseOptionsCountersCallsByResponse callsByResponse { get; set; }

        /// <summary>
        ///     Aggregation of calls count by segments (Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, Voicemail, VmGreeting,
        ///     Setup)
        /// </summary>
        public AggregationResponseOptionsCountersCallsSegments callsSegments { get; set; }

        /// <summary>
        ///     Aggregation of calls count by result (Completed, Abandoned, Voicemail, Unknown, Missed, Accepted, Transferred,
        ///     PickedUp, AnsweredElsewhere)
        /// </summary>
        public AggregationResponseOptionsCountersCallsByResult callsByResult { get; set; }

        /// <summary>
        ///     Aggregation of calls count by company hours (BusinessHours, AfterHours)
        /// </summary>
        public AggregationResponseOptionsCountersCallsByCompanyHours callsByCompanyHours { get; set; }

        /// <summary>
        ///     Aggregation of calls count by queue SLA (InSLA, OutSLA). This counter is only applicable to Queues grouping
        /// </summary>
        public AggregationResponseOptionsCountersCallsByQueueSla callsByQueueSla { get; set; }

        /// <summary>
        ///     Aggregation of calls count by action (HoldOff, HoldOn, ParkOn, ParkOff, BlindTransfer, WarmTransfer, DTMFTransfer)
        /// </summary>
        public AggregationResponseOptionsCountersCallsByActions callsByActions { get; set; }

        /// <summary>
        ///     Aggregation of calls count by type (Direct, FromQueue, ParkRetrieval, Transferred, Outbound, QueueCallPickup)
        /// </summary>
        public AggregationResponseOptionsCountersCallsByType callsByType { get; set; }

        /// <summary>
        ///     Aggregation of calls count by party that ended the call (Caller, Callee, System)
        /// </summary>
        public AggregationResponseOptionsCountersCallsByEndingParty callsByEndingParty { get; set; }

        /// <summary>
        ///     Aggregation of calls count by the total number of times a Queue call was presented to the user. It is limited to
        ///     `groupBy` Users and `groupByMembers` (Department, Queue, Site, UserGroup) grouping. Only the listed below options
        ///     for call filters are applicable to `queueOpportunities` and provide meaningful results: `queues` (selected queue
        ///     extension ids), `callResults` (Missed, Abandoned), `callResponses` (Answered, NotAnswered), `origins` (Internal,
        ///     External)
        /// </summary>
        public AggregationResponseOptionsCountersQueueOpportunities queueOpportunities { get; set; }

        /// <summary>
        ///     Aggregation of calls count by queue hours (BusinessHours, AfterHours)
        /// </summary>
        public AggregationResponseOptionsCountersCallsByQueueHours callsByQueueHours { get; set; }
    }
}