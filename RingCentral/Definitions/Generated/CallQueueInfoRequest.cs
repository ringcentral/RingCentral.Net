namespace RingCentral
{
    public class CallQueueInfoRequest
    {
        // Target percentage of calls that must be answered by agents within the service level time threshold
        public long? slaGoal;

        public long? slaThresholdSeconds;

        public bool? includeAbandonedCalls;

        public long? abandonedThresholdSeconds;
    }
}