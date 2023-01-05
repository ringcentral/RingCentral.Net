namespace RingCentral
{
    /// <summary>
    ///     Call queue service level settings
    /// </summary>
    public class CallQueueServiceLevelSettings
    {
        /// <summary>
        ///     Target percentage of calls that must be answered by agents
        ///     within the service level time threshold
        ///     Format: int32
        /// </summary>
        public long? slaGoal { get; set; }

        /// <summary>
        ///     The period of time in seconds that is considered to be an acceptable
        ///     service level
        ///     Format: int32
        /// </summary>
        public long? slaThresholdSeconds { get; set; }

        /// <summary>
        ///     Includes abandoned calls (when callers hang up prior to being
        ///     served by an agent) into service-level calculation
        /// </summary>
        public bool? includeAbandonedCalls { get; set; }

        /// <summary>
        ///     Abandoned calls that are shorter than the defined period of
        ///     time in seconds will not be included into the calculation of Service Level
        ///     Format: int32
        /// </summary>
        public long? abandonedThresholdSeconds { get; set; }
    }
}