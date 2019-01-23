namespace RingCentral
{
    public class PresenceInfoResource : Serializable
    {
        // Enum: Offline, Busy, Available
        public string userStatus;
        // Enum: TakeAllCalls, DoNotAcceptDepartmentCalls, TakeDepartmentCallsOnly, DoNotAcceptAnyCalls, Unknown
        public string dndStatus;
        public string message;
        public bool? allowSeeMyPresence;
        public bool? ringOnMonitoredCall;
        public bool? pickUpCallsOnHold;
        public ActiveCallInfo[] activeCalls;
    }
}