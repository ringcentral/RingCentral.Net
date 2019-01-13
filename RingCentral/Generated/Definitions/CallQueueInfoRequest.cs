using Newtonsoft.Json;

namespace RingCentral
{
    public class CallQueueInfoRequest : Serializable
    {
        // Target percentage of calls that must be answered by agents within the service level time threshold
        public int? slaGoal;
        public int? slaThresholdSeconds;
        public bool? includeAbandonedCalls;
        public int? abandonedThresholdSeconds;
    }
}