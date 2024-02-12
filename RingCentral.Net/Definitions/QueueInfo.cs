namespace RingCentral
{
    /// <summary>
    ///     Queue settings applied for department (call queue) extension type,
    ///     with the 'AgentQueue' value specified as a call handling action
    /// </summary>
    public class QueueInfo
    {
        /// <summary>
        ///     Specifies how calls are transferred to group members
        ///     Enum: Rotating, Simultaneous, FixedOrder
        /// </summary>
        public string transferMode { get; set; }

        /// <summary>
        ///     Call transfer information
        /// </summary>
        public TransferInfo[] transfer { get; set; }

        /// <summary>
        ///     Specifies the type of action to be taken if: members are available
        ///     but no one answers, or all members are busy/unavailable. This option is
        ///     available for Business hours only. For simultaneous transfer mode only
        ///     'WaitPrimaryMembers' and 'WaitPrimaryAndOverflowMembers' are supported
        ///     Enum: WaitPrimaryMembers, WaitPrimaryAndOverflowMembers, Voicemail, TransferToExtension, UnconditionalForwarding
        /// </summary>
        public string noAnswerAction { get; set; }

        /// <summary>
        ///     Information on a call forwarding rule
        /// </summary>
        public FixedOrderAgents[] fixedOrderAgents { get; set; }

        /// <summary>
        ///     Connecting audio interruption mode
        ///     Enum: Never, WhenMusicEnds, Periodically
        /// </summary>
        public string holdAudioInterruptionMode { get; set; }

        /// <summary>
        ///     Connecting audio interruption message period in seconds
        ///     Format: int32
        /// </summary>
        public long? holdAudioInterruptionPeriod { get; set; }

        /// <summary>
        ///     Specifies the type of action to be taken after the hold time
        ///     (waiting for an available call queue member) expires. If 'TransferToExtension'
        ///     option is selected, the extension specified in `transfer` field is used.
        ///     The default value is `Voicemail`
        ///     Default: Voicemail
        ///     Enum: TransferToExtension, UnconditionalForwarding, Voicemail
        /// </summary>
        public string holdTimeExpirationAction { get; set; }

        /// <summary>
        ///     Maximum time in seconds to wait for a call queue member before trying the next member
        ///     Format: int32
        /// </summary>
        public long? agentTimeout { get; set; }

        /// <summary>
        ///     Minimum post-call wrap up time in seconds before agent status
        ///     is automatically set; the value range is from 0 to 300 sec.
        ///     Maximum: 300
        ///     Format: int32
        ///     Default: 15
        /// </summary>
        public long? wrapUpTime { get; set; }

        /// <summary>
        ///     Maximum hold time in seconds to wait for an available call queue member
        ///     Format: int32
        /// </summary>
        public long? holdTime { get; set; }

        /// <summary>
        ///     Maximum count of callers on hold; the limitation is 25 callers
        ///     Maximum: 25
        ///     Format: int32
        /// </summary>
        public long? maxCallers { get; set; }

        /// <summary>
        ///     Specifies the type of action to be taken if count of callers on hold exceeds the supported maximum
        ///     Enum: Voicemail, Announcement, TransferToExtension, UnconditionalForwarding
        /// </summary>
        public string maxCallersAction { get; set; }

        /// <summary>
        /// </summary>
        public UnconditionalForwardingInfo[] unconditionalForwarding { get; set; }
    }
}