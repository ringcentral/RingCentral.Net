namespace RingCentral
{
    // For Department extension type only. Call queue settings
    public class CallQueueInfoRequest
    {
        /// <summary>
        /// Target percentage of calls that must be answered by agents within the service level time threshold
        /// </summary>
        public long? slaGoal { get; set; }

        /// <summary>
        /// </summary>
        public long? slaThresholdSeconds { get; set; }

        /// <summary>
        /// </summary>
        public bool? includeAbandonedCalls { get; set; }

        /// <summary>
        /// </summary>
        public long? abandonedThresholdSeconds { get; set; }
    }
}