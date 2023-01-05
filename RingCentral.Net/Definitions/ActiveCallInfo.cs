namespace RingCentral
{
    public class ActiveCallInfo
    {
        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        ///     Identifies if a call belongs to the call queue
        /// </summary>
        public bool? queueCall { get; set; }

        /// <summary>
        ///     Phone number or extension number of a caller. For GCM transport type '_from' property should be used
        /// </summary>
        public string from { get; set; }

        /// <summary>
        ///     Name of a caller
        /// </summary>
        public string fromName { get; set; }

        /// <summary>
        ///     Phone number or extension number of a callee
        /// </summary>
        public string to { get; set; }

        /// <summary>
        ///     Name of a callee
        /// </summary>
        public string toName { get; set; }

        /// <summary>
        ///     Time when the call is actually started
        ///     Format: date-time
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     Telephony presence status
        ///     Enum: NoCall, CallConnected, Ringing, OnHold, ParkedCall
        /// </summary>
        public string telephonyStatus { get; set; }

        /// <summary>
        /// </summary>
        public DetailedCallInfo sipData { get; set; }

        /// <summary>
        /// </summary>
        public string sessionId { get; set; }

        /// <summary>
        ///     Telephony identifier of a call session
        /// </summary>
        public string telephonySessionId { get; set; }

        /// <summary>
        ///     Extension ID of the call owner on whose behalf a call is performed
        /// </summary>
        public string onBehalfOf { get; set; }

        /// <summary>
        ///     Internal identifier of a call party
        /// </summary>
        public string partyId { get; set; }

        /// <summary>
        /// </summary>
        public string terminationType { get; set; }

        /// <summary>
        /// </summary>
        public CallInfoCQ callInfo { get; set; }
    }
}