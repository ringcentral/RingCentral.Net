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
            ///     if the new communication handling service is activated on account.
            ///     
            ///     Please note: Cannot be set for Department/Announcement/Voicemail
            ///     (Take Messages Only)/Fax User/Shared Lines Group/Paging Only Group/IVR
            ///     Menu/Application Extension/Park Location extensions.
            ///     
            ///     The 'DoNotAcceptDepartmentCalls' and 'TakeDepartmentCallsOnly' values
            ///     are applicable only for extensions - members of a Department; if these values
            ///     are set for department outsiders, the 400 Bad Request error code is returned.
            ///     
            ///     The 'TakeDepartmentCallsOnly' status can be set through the old RingCentral
            ///     user interface and is available for some migrated accounts only.
        ///     Enum: TakeAllCalls, DoNotAcceptDepartmentCalls, TakeDepartmentCallsOnly, DoNotAcceptAnyCalls, Unknown
        /// </summary>
        public string dndStatus { get; set; }

        /// <summary>
        ///     Do Not Disturb status of a User extension. Connected to the DND State type.
            ///     Applicable for User extensions if the new communication handling service is
            ///     activated on account.
        ///     Enum: TakeAllCalls, DoNotAcceptAnyCalls, Unknown
        /// </summary>
        public string dndStatusPersonal { get; set; }

        /// <summary>
        ///     Specifies if a Call Queue member extension will be able to receive Call Queue calls.
            ///     Used for the Agent state type. Applicable for User extensions if the new communication
            ///     handling service is activated on account
        /// </summary>
        public bool? acceptCallQueueCalls { get; set; }

        /// <summary>
        ///     Custom status message (as previously published by user)
        /// </summary>
        public string message { get; set; }

        /// <summary>
        ///     If set to `true` enables other extensions to see the extension presence status
        ///     Default: true
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

        /// <summary>
        ///     CX telephony status
        ///     Enum: NoCall, CallConnected
        /// </summary>
        public string cxTelephonyStatus { get; set; }

        /// <summary>
        ///     Telephony status of the extension aggregated across all telephony status sources.
        ///     Enum: NoCall, CallConnected, Ringing, OnHold, ParkedCall
        /// </summary>
        public string aggregatedTelephonyStatus { get; set; }
      }
  }