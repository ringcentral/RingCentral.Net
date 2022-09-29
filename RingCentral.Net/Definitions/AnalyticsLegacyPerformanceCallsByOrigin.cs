namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsByOrigin
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AnalyticsLegacyCallsByOrigin values { get; set; }
    }
}