namespace RingCentral
{
    public class CallQueueInfoRequest
    {
        /// <summary>
        /// Target percentage of calls that must be answered by agents within the service level time threshold
        /// </summary>
        public long? slaGoal;

        /// <summary>
        /// </summary>
        public long? slaThresholdSeconds;

        /// <summary>
        /// </summary>
        public bool? includeAbandonedCalls;

        /// <summary>
        /// </summary>
        public long? abandonedThresholdSeconds;
    }
}