namespace RingCentral
{
    public class PresenceInfoResponse
    {
        /// <summary>
        /// Link to the presence resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Enum: Offline, Busy, Available
        /// </summary>
        public string userStatus;

        /// <summary>
        /// Enum: TakeAllCalls, DoNotAcceptDepartmentCalls, TakeDepartmentCallsOnly, DoNotAcceptAnyCalls, Unknown
        /// </summary>
        public string dndStatus;

        /// <summary>
        /// </summary>
        public string message;

        /// <summary>
        /// </summary>
        public bool? allowSeeMyPresence;

        /// <summary>
        /// </summary>
        public bool? ringOnMonitoredCall;

        /// <summary>
        /// </summary>
        public bool? pickUpCallsOnHold;

        /// <summary>
        /// </summary>
        public ActiveCallInfo[] activeCalls;

        /// <summary>
        /// </summary>
        public GetPresenceExtensionInfo extension;

        /// <summary>
        /// Meetings presence status
        /// Enum: Connected, Disconnected
        /// </summary>
        public string meetingStatus;

        /// <summary>
        /// Telephony presence status. Returned if telephony status is changed
        /// Enum: NoCall, CallConnected, Ringing, OnHold, ParkedCall
        /// </summary>
        public string telephonyStatus;

        /// <summary>
        /// Aggregated presence status, calculated from a number of sources
        /// Enum: Offline, Busy, Available
        /// </summary>
        public string presenceStatus;
    }
}