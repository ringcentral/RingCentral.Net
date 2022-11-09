namespace RingCentral
{
    /// <summary>
    ///     Optional filters that limit the scope of calls (joined via AND)
    /// </summary>
    public class CallFilters
    {
        /// <summary>
        /// </summary>
        public ExtensionFilters extensionFilters { get; set; }

        /// <summary>
        ///     List of queues extension ids which allows to get data only for calls that were routed through any of these queues
        /// </summary>
        public string[] queues { get; set; }

        /// <summary>
        ///     The direct company numbers the caller called (joined via OR)
        /// </summary>
        public string[] calledNumbers { get; set; }

        /// <summary>
        ///     Specifies the call directions relative to the scope specified in grouping object (joined via OR). Not applicable to
        ///     internal origin calls with company scope
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string[] directions { get; set; }

        /// <summary>
        ///     Specifies whether an external party was present in the initial segment of the call (joined via OR)
        ///     Enum: Internal, External
        /// </summary>
        public string[] origins { get; set; }

        /// <summary>
        ///     Filtering of calls by first response (joined via OR)
        ///     Enum: Answered, NotAnswered, Connected, NotConnected
        /// </summary>
        public string[] callResponses { get; set; }

        /// <summary>
        ///     Filtering of calls by the nature of call result (joined via OR)
        ///     Enum: Completed, Abandoned, Voicemail, Unknown, Missed, Accepted
        /// </summary>
        public string[] callResults { get; set; }

        /// <summary>
        ///     Filtering of calls by presence of specific segment (joined via OR)
        /// </summary>
        public CallSegmentFilter[] callSegments { get; set; }

        /// <summary>
        ///     Filtering of calls by presence of specific action (joined via OR)
        ///     Enum: HoldOff, HoldOn, ParkOn, ParkOff, BlindTransfer, WarmTransfer, DTMFTransfer
        /// </summary>
        public string[] callActions { get; set; }

        /// <summary>
        ///     Filtering of calls by company's business hours or after hours (joined via OR)
        ///     Enum: BusinessHours, AfterHours
        /// </summary>
        public string[] companyHours { get; set; }

        /// <summary>
        /// </summary>
        public CallDurationFilter callDuration { get; set; }

        /// <summary>
        /// </summary>
        public TimeSpentFilter timeSpent { get; set; }

        /// <summary>
        ///     Filtering calls that were within or out of queue SLA (joined via OR). Only applicable to Queues grouping
        ///     Enum: InSla, OutSla
        /// </summary>
        public string[] queueSla { get; set; }

        /// <summary>
        ///     Filtering of calls based on how the call started from the callee perspective (joined via OR). If the call is
        ///     outbound relative to the grouping scope, CallType is Outbound
        ///     Enum: Direct, FromQueue, ParkRetrieval, Transferred, Outbound, Overflow
        /// </summary>
        public string[] callTypes { get; set; }
    }
}