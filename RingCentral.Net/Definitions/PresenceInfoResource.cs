namespace RingCentral
{
    public class PresenceInfoResource
    {
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
    }
}