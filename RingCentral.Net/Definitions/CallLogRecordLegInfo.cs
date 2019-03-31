namespace RingCentral
{
    public class CallLogRecordLegInfo
    {
        /// <summary>
        /// Action description of the call operation
        /// Enum: Unknown, Phone Call, Phone Login, Incoming Fax, Accept Call, FindMe, FollowMe, Outgoing Fax, Call Return, Calling Card, Ring Directly, RingOut Web, VoIP Call, RingOut PC, RingMe, Transfer, 411 Info, Emergency, E911 Update, Support, RingOut Mobile
        /// </summary>
        public string action;

        /// <summary>
        /// Call direction
        /// Enum: Inbound, Outbound
        /// </summary>
        public string direction;

        /// <summary>
        /// Call duration in seconds
        /// </summary>
        public long? duration;

        /// <summary>
        /// Information on extension
        /// </summary>
        public ExtensionInfoCallLog extension;

        /// <summary>
        /// Leg type
        /// Enum: SipForwarding, ServiceMinus2, ServiceMinus3, PstnToSip, Accept, FindMe, FollowMe, TestCall, FaxSent, CallBack, CallingCard, RingDirectly, RingOutWebToSubscriber, RingOutWebToCaller, SipToPstnMetered, RingOutClientToSubscriber, RingOutClientToCaller, RingMe, TransferCall, SipToPstnUnmetered, RingOutDeviceToSubscriber, RingOutDeviceToCaller, RingOutOneLegToCaller, ExtensionToExtension, CallPark, PagingServer, Hunting, OutgoingFreeSpDl, ParkLocation, ConferenceCall, MobileApp, MoveToConference, Unknown
        /// </summary>
        public string legType;

        /// <summary>
        /// The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        public string startTime;

        /// <summary>
        /// Call type
        /// Enum: Voice, Fax
        /// </summary>
        public string type;

        /// <summary>
        /// Status description of the call operation
        /// Enum: Unknown, ResultInProgress, Missed, Call accepted, Voicemail, Rejected, Reply, Received, Receive Error, Fax on Demand, Partial Receive, Blocked, Call connected, No Answer, International Disabled, Busy, Send Error, Sent, No fax machine, ResultEmpty, Account, Suspended, Call Failed, Call Failure, Internal Error, IP Phone offline, Restricted Number, Wrong Number, Stopped, Hang up, Poor Line Quality, Partially Sent, International Restriction, Abandoned, Declined, Fax Receipt Error, Fax Send Error
        /// </summary>
        public string result;

        /// <summary>
        /// Caller information
        /// </summary>
        public CallLogCallerInfo from;

        /// <summary>
        /// Callee information
        /// </summary>
        public CallLogCallerInfo to;

        /// <summary>
        /// Call transport
        /// Enum: PSTN, VoIP
        /// </summary>
        public string transport;

        /// <summary>
        /// Call recording data. Returned if the call is recorded
        /// </summary>
        public CallLogRecordingInfo recording;

        /// <summary>
        /// Returned for 'Detailed' call log. Specifies if the leg is master-leg
        /// </summary>
        public bool? master;
    }
}