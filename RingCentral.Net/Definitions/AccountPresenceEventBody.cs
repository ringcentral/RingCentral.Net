namespace RingCentral
{
    /// <summary>
    ///     Notification payload body
    /// </summary>
    public class AccountPresenceEventBody
    {
        /// <summary>
        ///     Internal identifier of an extension. Optional parameter
        ///     Default: ~
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Telephony presence status. Returned if telephony status is changed
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
        ///     Do Not Disturb status. Not applicable for User extensions
        ///     if the new communication handling service is activated on account
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
        ///     Meetings presence status. Specifies if a user is on a meeting
        ///     Enum: Connected, Disconnected
        /// </summary>
        public string meetingStatus { get; set; }

        /// <summary>
        ///     If set to `true` enables other extensions to see the extension presence status
        /// </summary>
        public bool? allowSeeMyPresence { get; set; }

        /// <summary>
        ///     Specifies if a Call Queue member extension will be able to receive Call Queue calls.
        ///     Used for the Agent state type. Applicable for User extensions if the new communication
        ///     handling service is activated on account
        /// </summary>
        public bool? acceptCallQueueCalls { get; set; }

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
        ///     Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId { get; set; }
    }
}