namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsSegments
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AnalyticsLegacyCallsSegments values { get; set; }
    }
}