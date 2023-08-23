namespace RingCentral
{
    public class GetPresenceInfo
    {
        /// <summary>
        ///     Canonical URI of a presence info resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     If set to 'True' - enables other extensions to see the extension presence status
        /// </summary>
        public bool? allowSeeMyPresence { get; set; }

        /// <summary>
        ///     Configures the user presence visibility. When the `allowSeeMyPresence` parameter is set to 'True',
        ///     the following visibility options are supported via this parameter - All, None, PermittedUsers
        ///     Enum: All, None, PermittedUsers
        /// </summary>
        public string callerIdVisibility { get; set; }

        /// <summary>
        ///     Extended DnD (Do not Disturb) status. Cannot be set for Department/Announcement/Voicemail
        ///     (Take Messages Only)/Fax User/Shared Lines Group/Paging Only Group/IVR
        ///     Menu/Application Extension/Park Location extensions. The 'DoNotAcceptDepartmentCalls'
        ///     and 'TakeDepartmentCallsOnly' values are applicable only for extensions
        ///     - members of a Department; if these values are set for department outsiders,
        ///     the 400 Bad Request error code is returned. The 'TakeDepartmentCallsOnly'
        ///     status can be set through the old RingCentral user interface and is available
        ///     for some migrated accounts only.
        ///     Enum: TakeAllCalls, DoNotAcceptAnyCalls, DoNotAcceptDepartmentCalls, TakeDepartmentCallsOnly
        /// </summary>
        public string dndStatus { get; set; }

        /// <summary>
        /// </summary>
        public GetPresenceExtensionInfo extension { get; set; }

        /// <summary>
        ///     Custom status message (as previously published by user)
        /// </summary>
        public string message { get; set; }

        /// <summary>
        ///     If 'True' enables the extension user to pick up a monitored line on hold
        /// </summary>
        public bool? pickUpCallsOnHold { get; set; }

        /// <summary>
        ///     Aggregated presence status, calculated from a number of sources
        ///     Enum: Offline, Busy, Available
        /// </summary>
        public string presenceStatus { get; set; }

        /// <summary>
        ///     If 'True' enables to ring extension phone, if any user monitored by this extension is ringing
        /// </summary>
        public bool? ringOnMonitoredCall { get; set; }

        /// <summary>
        ///     Telephony presence status
        ///     Enum: NoCall, CallConnected, Ringing, OnHold, ParkedCall
        /// </summary>
        public string telephonyStatus { get; set; }

        /// <summary>
        ///     User-defined presence status (as previously published by the user)
        ///     Enum: Offline, Busy, Available
        /// </summary>
        public string userStatus { get; set; }

        /// <summary>
        ///     RingCentral Meetings presence
        ///     Enum: Connected, Disconnected
        /// </summary>
        public string meetingStatus { get; set; }

        /// <summary>
        ///     Information on active calls
        /// </summary>
        public ActiveCallInfo[] activeCalls { get; set; }
    }
}