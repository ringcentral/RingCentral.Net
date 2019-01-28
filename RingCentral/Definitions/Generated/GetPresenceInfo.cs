namespace RingCentral
{
    public class GetPresenceInfo
    {
        // Canonical URI of a presence info resource
        public string uri;

        // If 'True' enables other extensions to see the extension presence status
        public bool? allowSeeMyPresence;

        // Extended DnD (Do not Disturb) status. Cannot be set for Department/Announcement/Voicemail (Take Messages Only)/Fax User/Shared Lines Group/Paging Only Group/IVR Menu/Application Extension/Park Location extensions. The 'DoNotAcceptDepartmentCalls' and 'TakeDepartmentCallsOnly' values are applicable only for extensions - members of a Department; if these values are set for department outsiders, the 400 Bad Request error code is returned. The 'TakeDepartmentCallsOnly' status can be set through the old RingCentral user interface and is available for some migrated accounts only.
        // Enum: TakeAllCalls, DoNotAcceptAnyCalls, DoNotAcceptDepartmentCalls, TakeDepartmentCallsOnly
        public string dndStatus;

        // Information on extension, for which this presence data is returned
        public GetPresenceExtensionInfo extension;

        // Custom status message (as previously published by user)
        public string message;

        // If 'True' enables the extension user to pick up a monitored line on hold
        public bool? pickUpCallsOnHold;

        // Aggregated presence status, calculated from a number of sources
        // Enum: Offline, Busy, Available
        public string presenceStatus;

        // If 'True' enables to ring extension phone, if any user monitored by this extension is ringing
        public bool? ringOnMonitoredCall;

        // Telephony presence status
        // Enum: NoCall, CallConnected, Ringing, OnHold, ParkedCall
        public string telephonyStatus;

        // User-defined presence status (as previously published by the user)
        // Enum: Offline, Busy, Available
        public string userStatus;

        // Meetings presence
        // Enum: Connected, Disconnected
        public string meetingsStatus;

        // Information on active calls
        public ActiveCallInfo[] activeCalls;
    }
}