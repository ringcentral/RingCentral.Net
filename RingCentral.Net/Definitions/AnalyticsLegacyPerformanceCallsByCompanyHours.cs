namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsByCompanyHours
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AnalyticsLegacyCallsByCompanyHours values { get; set; }
    }
}