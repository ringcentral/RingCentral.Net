namespace RingCentral
{
    // For Call Queue extension type only. Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in modern RingCentral product terminology
    public class CallQueueInfoRequest
    {
        /// <summary>
        ///     Target percentage of calls that must be answered by agents within the service level time threshold
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