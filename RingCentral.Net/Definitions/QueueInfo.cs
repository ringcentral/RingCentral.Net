namespace RingCentral
{
    // Queue settings applied for department (call queue) extension type, with the 'AgentQueue' value specified as a call handling action
    public class QueueInfo
    {
        /// <summary>
        /// Specifies how calls are transferred to group members
        /// Enum: Rotating, Simultaneous, FixedOrder
        /// </summary>
        public string transferMode;

        /// <summary>
        /// Call transfer information
        /// </summary>
        public TransferInfo[] transfer;

        /// <summary>
        /// Specifies the type of action to be taken if: members are available but no one answers, or all members are busy/unavailable. This option is available for Business hours only. For simultaneous transfer mode only 'WaitPrimaryMembers' and 'WaitPrimaryAndOverflowMembers' are supported
        /// Enum: WaitPrimaryMembers, WaitPrimaryAndOverflowMembers, Voicemail, TransferToExtension, UnconditionalForwarding
        /// </summary>
        public string noAnswerAction;

        /// <summary>
        /// Information on a call forwarding rule
        /// </summary>
        public FixedOrderAgents[] fixedOrderAgents;

        /// <summary>
        /// Connecting audio interruption mode
        /// Enum: Never, WhenMusicEnds, Periodically
        /// </summary>
        public string holdAudioInterruptionMode;

        /// <summary>
        /// Connecting audio interruption message period in seconds
        /// </summary>
        public long? holdAudioInterruptionPeriod;

        /// <summary>
        /// Specifies the type of action to be taken after the hold time (waiting for an available call queue member) expires. If 'TransferToExtension' option is selected, the extension specified in `transfer` field is used. The default value is `Voicemail`
        /// Default: Voicemail
        /// Enum: TransferToExtension, UnconditionalForwarding, Voicemail
        /// </summary>
        public string holdTimeExpirationAction;

        /// <summary>
        /// Maximum time in seconds to wait for a call queue member before trying the next member
        /// </summary>
        public long? agentTimeout;

        /// <summary>
        /// Minimum post-call wrap up time in seconds before agent status is automatically set; the value range is from 180 to 300
        /// </summary>
        public long? wrapUpTime;

        /// <summary>
        /// Maximum hold time in seconds to wait for an available call queue member
        /// </summary>
        public long? holdTime;

        /// <summary>
        /// Maximum count of callers on hold; the limitation is 25 callers
        /// </summary>
        public long? maxCallers;

        /// <summary>
        /// Specifies the type of action to be taken if count of callers on hold exceeds the supported maximum
        /// Enum: Voicemail, Announcement, TransferToExtension, UnconditionalForwarding
        /// </summary>
        public string maxCallersAction;

        /// <summary>
        /// </summary>
        public UnconditionalForwardingInfo[] unconditionalForwarding;
    }
}