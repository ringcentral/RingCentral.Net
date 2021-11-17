namespace RingCentral
{
    // Optional filters that limit the scope of calls to be aggregated. Multiple values can be joined via 'AND'
    public class PerformanceCallsFilters
    {
        /// <summary>
        ///     Specifies whether a call is inbound or outbound relative to the account. Not applicable to internal calls
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        ///     Specifies whether a call was originated within the account or outside of it
        ///     Enum: Internal, External
        /// </summary>
        public string origin { get; set; }

        /// <summary>
        ///     Aggregation of calls by the first response
        ///     Enum: Answered, NotAnswered
        /// </summary>
        public string callResponse { get; set; }

        /// <summary>
        ///     List of call response types. Multiple values can be joined via 'OR'
        ///     Enum: InboundDirect, ParkRetrievals, QueueCalls, Transferred, Missed, Accepted
        /// </summary>
        public string[] callResponseType { get; set; }

        /// <summary>
        ///     Aggregation of calls by the nature of call result. Multiple values can be joined via 'OR'
        ///     Enum: Completed, Abandoned, VoiceMail, Connected
        /// </summary>
        public string[] callResult { get; set; }

        /// <summary>
        ///     Aggregation of calls by presence of specific segment. Multiple values can be joined via 'OR'
        /// </summary>
        public CallSegmentFilter[] callSegments { get; set; }

        /// <summary>
        ///     Aggregation of calls by presence of specific action (joined via OR)
        /// </summary>
        public CallPerformanceActionInfo[] callActions { get; set; }

        /// <summary>
        ///     Aggregation of calls by company business hours or after hours.
        ///     Enum: BusinessHours, AfterHours
        /// </summary>
        public string companyHours { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsFilterByLength callDuration { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsFilterTimeSpentByMailbox timeSpent { get; set; }

        /// <summary>
        ///     List of extension identifiers from which the users specified in 'groupBy' received calls. Multiple values can be
        ///     joined via 'OR'
        /// </summary>
        public string[] callerExtensionIds { get; set; }

        /// <summary>
        ///     List of extension identifiers to which the users specified in 'groupBy' placed calls. Multiple values can be joined
        ///     via 'OR'
        /// </summary>
        public string[] calledExtensionIds { get; set; }

        /// <summary>
        ///     Direct numbers the caller dialed. Multiple values can be joined via 'OR'
        /// </summary>
        public string[] calledNumbers { get; set; }

        /// <summary>
        ///     This filter allows to get aggregation of calls that were either within or out of queue SLA. Only applicable to
        ///     Queues grouping
        ///     Enum: InSla, OutSla
        /// </summary>
        public string callSla { get; set; }
    }
}