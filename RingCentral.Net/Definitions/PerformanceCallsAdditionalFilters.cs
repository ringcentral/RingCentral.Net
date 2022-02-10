namespace RingCentral
{
    /// <summary>
    ///     Optional filters that limit the scope of calls to be aggregated. Multiple values can be joined via 'AND'
    /// </summary>
    public class PerformanceCallsAdditionalFilters
    {
        /// <summary>
        ///     Specifies whether the call was inbound or outbound relative to the scope specified in grouping object. Not
        ///     applicable to internal calls with company scope (when grouping is not specified)
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        ///     Specifies whether an external party was present in the initial segment of the call
        ///     Enum: Internal, External
        /// </summary>
        public string origin { get; set; }

        /// <summary>
        ///     Aggregation of calls by the first response
        ///     Enum: Answered, NotAnswered, Connected, NotConnected
        /// </summary>
        public string callResponse { get; set; }

        /// <summary>
        ///     List of call response types. This filter allows to get aggregation of calls based on how the call started from the
        ///     callee perspective. Multiple values can be joined via 'OR'. If the call is outbound relative to the grouping scope,
        ///     `callType` is Outbound
        ///     Enum: Direct, Outbound, ParkRetrieval, FromQueue, Transferred
        /// </summary>
        public string[] callType { get; set; }

        /// <summary>
        ///     Aggregation of calls by the nature of call result. Multiple values can be joined via 'OR'
        ///     Enum: Completed, Abandoned, VoiceMail, Unknown, Missed, Accepted
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
        public string queueSla { get; set; }
    }
}