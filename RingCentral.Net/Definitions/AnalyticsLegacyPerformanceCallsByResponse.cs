namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsByResponse
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AnalyticsLegacyCallsByResponse values { get; set; }
    }
}