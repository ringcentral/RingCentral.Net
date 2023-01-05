namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsByQueueSla
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AnalyticsLegacyCallsByQueueSla values { get; set; }
    }
}