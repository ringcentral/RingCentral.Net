namespace RingCentral
{
    public class CallLogRecordLegInfo
    {
        /// <summary>
        ///     The internal action corresponding to the call operation
        ///     Enum: Unknown, Phone Call, Phone Login, Calling Card, VoIP Call, Paging, Hunting, Call Park, Monitoring, Text
        ///     Relay, External Application, Park Location, CallOut-CallMe, Conference Call, Move, RC Meetings, Accept Call,
        ///     FindMe, FollowMe, RingMe, Transfer, Call Return, Ring Directly, RingOut Web, RingOut PC, RingOut Mobile, 411 Info,
        ///     Emergency, E911 Update, Support, Incoming Fax, Outgoing Fax
        /// </summary>
        public string action { get; set; }

        /// <summary>
        ///     The direction of a call
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        /// </summary>
        public BillingInfo billing { get; set; }

        /// <summary>
        /// </summary>
        public CallLogDelegateInfo @delegate { get; set; }

        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Call duration in seconds
        ///     Format: int32
        /// </summary>
        public long? duration { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionInfoCallLog extension { get; set; }

        /// <summary>
        ///     Leg type
        ///     Enum: SipForwarding, ServiceMinus2, ServiceMinus3, PstnToSip, Accept, FindMe, FollowMe, TestCall, FaxSent,
        ///     CallBack, CallingCard, RingDirectly, RingOutWebToSubscriber, RingOutWebToCaller, SipToPstnMetered,
        ///     RingOutClientToSubscriber, RingOutClientToCaller, RingMe, TransferCall, SipToPstnUnmetered,
        ///     RingOutDeviceToSubscriber, RingOutDeviceToCaller, RingOutOneLegToCaller, ExtensionToExtension, CallPark,
        ///     PagingServer, Hunting, OutgoingFreeSpDl, ParkLocation, ConferenceCall, MobileApp, Monitoring, MoveToConference,
        ///     Unknown
        /// </summary>
        public string legType { get; set; }

        /// <summary>
        ///     The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     The type of a call
        ///     Enum: Voice, Fax
        /// </summary>
        public string type { get; set; }

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
        /// </summary>
        public CallLogCallerInfo from { get; set; }

        /// <summary>
        /// </summary>
        public CallLogCallerInfo to { get; set; }

        /// <summary>
        ///     The type of a call transport. 'PSTN' indicates that a call leg was initiated
        ///     from the PSTN network provider; 'VoIP' - from an RC phone.
        ///     Enum: PSTN, VoIP
        /// </summary>
        public string transport { get; set; }

        /// <summary>
        /// </summary>
        public CallLogRecordingInfo recording { get; set; }

        /// <summary>
        ///     Indicates that the recording is too short and therefore wouldn't be returned. The flag is not returned if the value
        ///     is false
        /// </summary>
        public bool? shortRecording { get; set; }

        /// <summary>
        ///     Returned for 'Detailed' call log. Specifies if the leg is master-leg
        /// </summary>
        public bool? master { get; set; }

        /// <summary>
        /// </summary>
        public CallLogRecordMessage message { get; set; }

        /// <summary>
        ///     Telephony identifier of a call session
        /// </summary>
        public string telephonySessionId { get; set; }

        /// <summary>
        ///     Call session identifier, required for Telephony REST API
        /// </summary>
        public string sipUuidInfo { get; set; }

        /// <summary>
        /// </summary>
        public CallLogRecordLegInfoTransferTarget transferTarget { get; set; }

        /// <summary>
        /// </summary>
        public CallLogRecordLegInfoTransferee transferee { get; set; }

        /// <summary>
        ///     Internal Identifier of Participant
        /// </summary>
        public string partyId { get; set; }

        /// <summary>
        ///     The internal type of the call
        ///     Enum: Local, LongDistance, International, Sip, RingMe, RingOut, Usual, TollFreeNumber, VerificationNumber, Vma,
        ///     LocalNumber, ImsOutgoing, ImsIncoming
        /// </summary>
        public string internalType { get; set; }
    }
}