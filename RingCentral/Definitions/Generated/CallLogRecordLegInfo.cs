namespace RingCentral
{
    public class CallLogRecordLegInfo : Serializable
    {
        // Action description of the call operation
        // Enum: Unknown, Phone Call, Phone Login, Incoming Fax, Accept Call, FindMe, FollowMe, Outgoing Fax, Call Return, Calling Card, Ring Directly, RingOut Web, VoIP Call, RingOut PC, RingMe, Transfer, 411 Info, Emergency, E911 Update, Support, RingOut Mobile
        public string action;

        // Call direction
        // Enum: Inbound, Outbound
        public string direction;

        // Call duration in seconds
        public long? duration;

        // Information on extension
        public ExtensionInfoCallLog extension;

        // Leg type
        // Enum: SipForwarding, ServiceMinus2, ServiceMinus3, PstnToSip, Accept, FindMe, FollowMe, TestCall, FaxSent, CallBack, CallingCard, RingDirectly, RingOutWebToSubscriber, RingOutWebToCaller, SipToPstnMetered, RingOutClientToSubscriber, RingOutClientToCaller, RingMe, TransferCall, SipToPstnUnmetered, RingOutDeviceToSubscriber, RingOutDeviceToCaller, RingOutOneLegToCaller, ExtensionToExtension, CallPark, PagingServer, Hunting, OutgoingFreeSpDl, ParkLocation, ConferenceCall, MobileApp, MoveToConference, Unknown
        public string legType;

        // The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string startTime;

        // Call type
        // Enum: Voice, Fax
        public string type;

        // Status description of the call operation
        // Enum: Unknown, ResultInProgress, Missed, Call accepted, Voicemail, Rejected, Reply, Received, Receive Error, Fax on Demand, Partial Receive, Blocked, Call connected, No Answer, International Disabled, Busy, Send Error, Sent, No fax machine, ResultEmpty, Account, Suspended, Call Failed, Call Failure, Internal Error, IP Phone offline, Restricted Number, Wrong Number, Stopped, Hang up, Poor Line Quality, Partially Sent, International Restriction, Abandoned, Declined, Fax Receipt Error, Fax Send Error
        public string result;

        // Caller information
        public CallLogCallerInfo from;

        // Callee information
        public CallLogCallerInfo to;

        // Call transport
        // Enum: PSTN, VoIP
        public string transport;

        // Call recording data. Returned if the call is recorded
        public RecordingInfo recording;
        public bool? master;
    }
}