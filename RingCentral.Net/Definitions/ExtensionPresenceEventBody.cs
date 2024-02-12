namespace RingCentral
{
    public class ExtensionPresenceEventBody
    {
        /// <summary>
        ///     Internal identifier of an extension. Optional parameter
        ///     Default: ~
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Telephony presence status. Returned if telephony status is changed.
        ///     Enum: NoCall, CallConnected, Ringing, OnHold, ParkedCall
        /// </summary>
        public string telephonyStatus { get; set; }

        /// <summary>
        ///     Order number of a notification to state the chronology
        ///     Format: int32
        /// </summary>
        public long? sequence { get; set; }

        /// <summary>
        ///     Aggregated presence status, calculated from a number of sources
        ///     Enum: Offline, Busy, Available
        /// </summary>
        public string presenceStatus { get; set; }

        /// <summary>
        ///     User-defined presence status (as previously published by the user)
        ///     Enum: Offline, Busy, Available
        /// </summary>
        public string userStatus { get; set; }

        /// <summary>
        ///     Extended DnD (Do not Disturb) status
        ///     Enum: TakeAllCalls, DoNotAcceptAnyCalls, DoNotAcceptDepartmentCalls, TakeDepartmentCallsOnly
        /// </summary>
        public string dndStatus { get; set; }

        /// <summary>
        ///     If `true` enables other extensions to see the extension presence status
        /// </summary>
        public bool? allowSeeMyPresence { get; set; }

        /// <summary>
        ///     If `true` enables to ring extension phone, if any user monitored by this extension is ringing
        /// </summary>
        public bool? ringOnMonitoredCall { get; set; }

        /// <summary>
        ///     If `true` enables the extension user to pick up a monitored line on hold
        /// </summary>
        public bool? pickUpCallsOnHold { get; set; }

        /// <summary>
        ///     Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId { get; set; }
    }
}