namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsTotal
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? values { get; set; }
    }
}