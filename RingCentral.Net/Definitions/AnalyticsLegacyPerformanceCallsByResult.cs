namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsByResult
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AnalyticsLegacyCallsByResult values { get; set; }
    }
}