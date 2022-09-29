namespace RingCentral
{
    public class PresenceInfoResponse
    {
        /// <summary>
        ///     Link to the presence resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Enum: Offline, Busy, Available
        /// </summary>
        public string userStatus { get; set; }

        /// <summary>
        ///     Enum: TakeAllCalls, DoNotAcceptDepartmentCalls, TakeDepartmentCallsOnly, DoNotAcceptAnyCalls, Unknown
        /// </summary>
        public string dndStatus { get; set; }

        /// <summary>
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// </summary>
        public bool? allowSeeMyPresence { get; set; }

        /// <summary>
        /// </summary>
        public bool? ringOnMonitoredCall { get; set; }

        /// <summary>
        /// </summary>
        public bool? pickUpCallsOnHold { get; set; }

        /// <summary>
        /// </summary>
        public ActiveCallInfo[] activeCalls { get; set; }

        /// <summary>
        /// </summary>
        public GetPresenceExtensionInfo extension { get; set; }

        /// <summary>
        ///     Meetings presence status
        ///     Enum: Connected, Disconnected
        /// </summary>
        public string meetingStatus { get; set; }

        /// <summary>
        ///     Telephony presence status. Returned if telephony status is changed
        ///     Enum: NoCall, CallConnected, Ringing, OnHold, ParkedCall
        /// </summary>
        public string telephonyStatus { get; set; }

        /// <summary>
        ///     Aggregated presence status, calculated from a number of sources
        ///     Enum: Offline, Busy, Available
        /// </summary>
        public string presenceStatus { get; set; }
    }
}