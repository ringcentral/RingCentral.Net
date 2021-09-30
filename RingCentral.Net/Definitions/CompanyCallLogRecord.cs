namespace RingCentral
{
    public class CompanyCallLogRecord
    {
        /// <summary>
        ///     Internal identifier of a cal log record
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of a call log record
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a call session
        /// </summary>
        public string sessionId { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionInfoCallLog extension { get; set; }

        /// <summary>
        ///     Telephony identifier of a call session
        /// </summary>
        public string telephonySessionId { get; set; }

        /// <summary>
        ///     Call transport
        ///     Enum: PSTN, VoIP
        /// </summary>
        public string transport { get; set; }

        /// <summary>
        /// </summary>
        public CallLogCallerInfo from { get; set; }

        /// <summary>
        /// </summary>
        public CallLogCallerInfo to { get; set; }

        /// <summary>
        ///     Call type
        ///     Enum: Voice, Fax
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Call direction
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        /// </summary>
        public CallLogRecordMessage message { get; set; }

        /// <summary>
        /// </summary>
        public CallLogDelegateInfo @delegate { get; set; }

        /// <summary>
        ///     Indicates whether the record is deleted. Returned for deleted records, for ISync requests
        /// </summary>
        public bool? deleted { get; set; }

        /// <summary>
        ///     Action description of the call operation
        ///     Enum: Unknown, Phone Login, Calling Card, VoIP Call, Phone Call, Paging, Hunting, Call Park, Monitoring, Text
        ///     Relay, External Application, Park Location, CallOut-CallMe, Conference Call, Move, RC Meetings, Accept Call,
        ///     FindMe, FollowMe, RingMe, Transfer, Call Return, Ring Directly, RingOut Web, RingOut PC, RingOut Mobile, Emergency,
        ///     E911 Update, Support, Incoming Fax, Outgoing Fax
        /// </summary>
        public string action { get; set; }

        /// <summary>
        ///     Status description of the call operation
        ///     Enum: Unknown, Accepted, Call connected, In Progress, Voicemail, Reply, Missed, Busy, Rejected, No Answer, Hang Up,
        ///     Blocked, Suspended account, Call Failed, Call Failure, Internal Error, IP Phone Offline, No Calling Credit,
        ///     Restricted Number, Wrong Number, Answered Not Accepted, Stopped, International Disabled, International Restricted,
        ///     Abandoned, Declined, Received, Fax on Demand, Partial Receive, Receive Error, Fax Receipt Error, Sent, Fax
        ///     Partially Sent, Send Error, Fax Not Sent, Fax Poor Line
        /// </summary>
        public string result { get; set; }

        /// <summary>
        ///     Enum: Accepted, Connected, line Busy, Not Answered, No Answer, Hang Up, Stopped, Internal Error, No Credit,
        ///     Restricted Number, Wrong Number, International Disabled, International Restricted, Bad Number, Info 411 Restricted,
        ///     Customer 611 Restricted, No Digital Line, Failed Try Again, Max Call Limit, Too Many Calls, Calls Not Accepted,
        ///     Number Not Allowed, Number Blocked, Number Disabled, Resource Error, Call Loop, Fax Not Received, Fax Partially
        ///     Sent, Fax Not Sent, Fax Poor Line, Fax Prepare Error, Fax Save Error, Fax Send Error
        /// </summary>
        public string reason { get; set; }

        /// <summary>
        /// </summary>
        public string reasonDescription { get; set; }

        /// <summary>
        ///     The call start datetime in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone, for
        ///     example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     Call duration in seconds
        /// </summary>
        public long? duration { get; set; }

        /// <summary>
        /// </summary>
        public CallLogRecordingInfo recording { get; set; }

        /// <summary>
        ///     Indicates that the recording is too short and therefore wouldn't be returned. The flag is not returned if the value
        ///     is false
        /// </summary>
        public bool? shortRecording { get; set; }

        /// <summary>
        ///     For 'Detailed' view only. Leg description
        /// </summary>
        public CallLogRecordLegInfo[] legs { get; set; }

        /// <summary>
        /// </summary>
        public BillingInfo billing { get; set; }

        /// <summary>
        ///     For 'Detailed' view only. The datetime when the call log record was modified in (ISO
        ///     8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone, for example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Internal type of a call
        ///     Enum: Local, LongDistance, International, Sip, RingMe, RingOut, Usual, TollFreeNumber, VerificationNumber, Vma,
        ///     LocalNumber, ImsOutgoing, ImsIncoming
        /// </summary>
        public string internalType { get; set; }
    }
}