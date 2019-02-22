namespace RingCentral
{
    public class DetailedExtensionPresenceWithSIPEventBody
    {
        // Internal identifier of an extension
        // Default: ~
        public string extensionId;

        // Telephony presence status. Returned if telephony status is changed.
        // Enum: NoCall, CallConnected, Ringing, OnHold, ParkedCall
        public string telephonyStatus;

        // List of the latest 10 active calls on extension
        public ActiveCallInfo[] activeCalls;

        // Order number of a notification to state the chronology
        public long? sequence;

        // Aggregated presence status, calculated from a number of sources
        // Enum: Offline, Busy, Available
        public string presenceStatus;

        // User-defined presence status (as previously published by the user)
        // Enum: Offline, Busy, Available
        public string userStatus;

        // Extended DnD (Do not Disturb) status
        // Enum: TakeAllCalls, DoNotAcceptAnyCalls, DoNotAcceptDepartmentCalls, TakeDepartmentCallsOnly
        public string dndStatus;

        // If 'True' enables other extensions to see the extension presence status
        public bool? allowSeeMyPresence;

        // If 'True' enables to ring extension phone, if any user monitored by this extension is ringing
        public bool? ringOnMonitoredCall;

        // If 'True' enables the extension user to pick up a monitored line on hold
        public bool? pickUpCallsOnHold;

        // Total number of active calls on extension at the present moment
        public long? totalActiveCalls;

        // Internal identifier of a subscription owner extension
        public string ownerId;
    }
}