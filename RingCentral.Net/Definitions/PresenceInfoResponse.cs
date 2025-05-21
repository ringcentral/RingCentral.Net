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
        ///     User-defined presence status (as previously published by the user)
        ///     Enum: Offline, Busy, Available
        /// </summary>
        public string userStatus { get; set; }

        /// <summary>
        ///     Do Not Disturb status. Not applicable for User extensions
        ///     if the new communication handling service is activated on account
        ///     Enum: TakeAllCalls, DoNotAcceptDepartmentCalls, TakeDepartmentCallsOnly, DoNotAcceptAnyCalls, Unknown
        /// </summary>
        public string dndStatus { get; set; }

        /// <summary>
        ///     Do Not Disturb status of a User extension. Applicable for User extensions
        ///     if the new communication handling service is activated on account
        ///     Enum: TakeAllCalls, DoNotAcceptAnyCalls, Unknown
        /// </summary>
        public string dndStatusPersonal { get; set; }

        /// <summary>
        ///     Specifies if a Call Queue member extension will be able to receive Call Queue calls.
        ///     Applicable for User extensions if the new communication handling service is activated on account.
        ///     Used for Agent state type
        /// </summary>
        public bool? acceptCallQueueCalls { get; set; }

        /// <summary>
        ///     Custom status message (as previously published by user)
        /// </summary>
        public string message { get; set; }

        /// <summary>
        ///     If set to `true` enables other extensions to see the extension presence status
        /// </summary>
        public bool? allowSeeMyPresence { get; set; }

        /// <summary>
        ///     Configures the user presence visibility. When the `allowSeeMyPresence` parameter is set to `true`,
        ///     the following visibility options are supported via this parameter - All, None, PermittedUsers
        ///     Enum: All, None, PermittedUsers
        /// </summary>
        public string callerIdVisibility { get; set; }

        /// <summary>
        ///     If `true` enables to ring extension phone, if any user monitored
        ///     by this extension is ringing
        /// </summary>
        public bool? ringOnMonitoredCall { get; set; }

        /// <summary>
        ///     If `true` enables the extension user to pick up a monitored line on hold
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