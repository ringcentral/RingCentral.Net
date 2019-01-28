namespace RingCentral
{
    public class ActiveCallInfo
    {
        public string id;

        // Enum: Inbound, Outbound
        public string direction;

        // Phone number or extension number of a caller. For GCM transport type '_from' property should be used
        public string from;

        // Name of a caller
        public string fromName;

        // Phone number or extension number of a callee
        public string to;

        // Name of a callee
        public string toName;

        // Time when the call is actually started
        public string startTime;
        public string telephonyStatus;
        public DetailedCallInfo sipData;
        public string sessionId;
        public string terminationType;
    }
}