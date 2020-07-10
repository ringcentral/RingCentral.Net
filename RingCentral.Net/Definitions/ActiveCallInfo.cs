namespace RingCentral
{
    public class ActiveCallInfo
    {
        /// <summary>
        /// </summary>
        public string id;

        /// <summary>
        /// Enum: Inbound, Outbound
        /// </summary>
        public string direction;

        /// <summary>
        /// Phone number or extension number of a caller. For GCM transport type '_from' property should be used
        /// </summary>
        public string from;

        /// <summary>
        /// Name of a caller
        /// </summary>
        public string fromName;

        /// <summary>
        /// Phone number or extension number of a callee
        /// </summary>
        public string to;

        /// <summary>
        /// Name of a callee
        /// </summary>
        public string toName;

        /// <summary>
        /// Time when the call is actually started
        /// </summary>
        public string startTime;

        /// <summary>
        /// Telephony presence status
        /// Enum: NoCall, CallConnected, Ringing, OnHold, ParkedCall
        /// </summary>
        public string telephonyStatus;

        /// <summary>
        /// </summary>
        public DetailedCallInfo sipData;

        /// <summary>
        /// </summary>
        public string sessionId;

        /// <summary>
        /// Telephony identifier of a call session
        /// </summary>
        public string telephonySessionId;

        /// <summary>
        /// Extension ID of the call owner on whose behalf a call is performed
        /// </summary>
        public string onBehalfOf;

        /// <summary>
        /// Internal identifier of a call party
        /// </summary>
        public string partyId;

        /// <summary>
        /// </summary>
        public string terminationType;

        /// <summary>
        /// Primary call session information. Supported for Call Queues only
        /// </summary>
        public PrimaryCQInfo primary;

        /// <summary>
        /// Additional call session information. Supported for Call Queues only
        /// </summary>
        public AdditionalCQInfo additional;
    }
}