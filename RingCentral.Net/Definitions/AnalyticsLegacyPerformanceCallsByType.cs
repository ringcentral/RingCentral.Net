namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsByType
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AnalyticsLegacyCallsByType values { get; set; }
    }
}