namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsActions
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AnalyticsLegacyCallsActions values { get; set; }
    }
}