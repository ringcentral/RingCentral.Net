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
        ///     Format: uri
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
        ///     The type of a call transport. 'PSTN' indicates that a call leg was initiated
        ///     from the PSTN network provider; 'VoIP' - from an RC phone.
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
        ///     The type of a call
        ///     Enum: Voice, Fax
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     The direction of a call
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
        ///     The internal action corresponding to the call operation
        ///     Enum: Unknown, Phone Call, Phone Login, Calling Card, VoIP Call, Paging, Hunting, Call Park, Monitoring, Text
        ///     Relay, External Application, Park Location, CallOut-CallMe, Conference Call, Move, RC Meetings, Accept Call,
        ///     FindMe, FollowMe, RingMe, Transfer, Call Return, Ring Directly, RingOut Web, RingOut PC, RingOut Mobile, 411 Info,
        ///     Emergency, E911 Update, Support, Incoming Fax, Outgoing Fax
        /// </summary>
        public string action { get; set; }

        /// <summary>
        ///     The result of the call operation
        ///     Enum: Unknown, Accepted, Call connected, In Progress, Voicemail, Reply, Missed, Busy, Rejected, No Answer, Hang Up,
        ///     Blocked, ResultEmpty, Suspended account, Call Failed, Call Failure, Internal Error, IP Phone Offline, No Calling
        ///     Credit, Not Allowed, Restricted Number, Wrong Number, Answered Not Accepted, Stopped, Poor Line Quality,
        ///     International Disabled, International Restricted, Abandoned, Declined, Received, Fax on Demand, Partial Receive,
        ///     Receive Error, Fax Receipt Error, Fax Partially Sent, No fax machine, Send Error, Sent, Fax Not Sent, Fax Poor Line
        /// </summary>
        public string result { get; set; }

        /// <summary>
        /// </summary>
        public string reasonDescription { get; set; }

        /// <summary>
        ///     The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     Call duration in seconds
        ///     Format: int32
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
        ///     For 'Detailed' view only. The datetime when the call log record
        ///     was modified in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format
        ///     including timezone, for example *2016-03-10T18:07:52.534Z*
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     The internal type of the call
        ///     Enum: Local, LongDistance, International, Sip, RingMe, RingOut, Usual, TollFreeNumber, VerificationNumber, Vma,
        ///     LocalNumber, ImsOutgoing, ImsIncoming
        /// </summary>
        public string internalType { get; set; }
    }
}