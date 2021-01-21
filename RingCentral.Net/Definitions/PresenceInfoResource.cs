namespace RingCentral
{
    public class PresenceInfoResource
    {
        /// <summary>
        /// Enum: Offline, Busy, Available
        /// </summary>
        public string userStatus { get; set; }

        /// <summary>
        /// Enum: TakeAllCalls, DoNotAcceptDepartmentCalls, TakeDepartmentCallsOnly, DoNotAcceptAnyCalls, Unknown
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
    }
}