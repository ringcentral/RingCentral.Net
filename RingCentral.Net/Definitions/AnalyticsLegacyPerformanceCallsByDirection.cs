namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsByDirection
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AnalyticsLegacyCallsByDirection values { get; set; }
    }
}