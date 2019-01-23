namespace RingCentral
{
    public class QueueInfo : Serializable
    {
        // Specifies how calls are transferred to group members
        // Enum: Rotating, Simultaneous, FixedOrder
        public string transferMode;

        // Information on a call forwarding rule
        public FixedOrderAgents[] fixedOrderAgents;

        // Connecting audio interruption mode
        // Enum: Never, WhenMusicEnds, Periodically
        public string holdAudioInterruptionMode;

        // Connecting audio interruption message period in seconds
        public long? holdAudioInterruptionPeriod;

        // Maximum time in seconds to wait for a call queue member before trying the next member
        public long? agentTimeout;

        // Minimum post-call wrap up time in seconds before agent status is automatically set
        public long? wrapUpTime;

        // Maximum hold time in seconds to wait for an available call queue member
        public long? holdTime;

        // Maximum count of callers on hold
        public long? maxCallers;

        // Action which should be taken if count of callers on hold exceeds the maximum
        // Enum: Voicemail, Announcement
        public string maxCallersAction;
    }
}