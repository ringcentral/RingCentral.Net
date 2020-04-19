namespace RingCentral
{
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
        /// Specifies the type of action to be taken after the hold time (waiting for an available call queue member) expires. If 'TransferToExtension' option is selected, the extension specified in `transfer` field is used
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
        /// Action which should be taken if count of callers on hold exceeds the maximum
        /// Enum: Voicemail, Announcement, TransferToExtension, UnconditionalForwarding
        /// </summary>
        public string maxCallersAction;

        /// <summary>
        /// </summary>
        public UnconditionalForwardingInfo[] unconditionalForwarding;
    }
}