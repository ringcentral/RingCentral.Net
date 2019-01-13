using Newtonsoft.Json;

namespace RingCentral
{
    public class QueueInfo : Serializable
    {
        // Specifies how calls are transferred to group members
        public string transferMode;
        // Information on a call forwarding rule
        public FixedOrderAgents[] fixedOrderAgents;
        // Connecting audio interruption mode
        public string holdAudioInterruptionMode;
        // Connecting audio interruption message period in seconds
        public int? holdAudioInterruptionPeriod;
        // Maximum time in seconds to wait for a call queue member before trying the next member
        public int? agentTimeout;
        // Minimum post-call wrap up time in seconds before agent status is automatically set
        public int? wrapUpTime;
        // Maximum hold time in seconds to wait for an available call queue member
        public int? holdTime;
        // Maximum count of callers on hold
        public int? maxCallers;
        // Action which should be taken if count of callers on hold exceeds the maximum
        public string maxCallersAction;
    }
}