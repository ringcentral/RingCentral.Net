namespace RingCentral
{
    public class AnalyticsLegacyTimelineData
    {
        /// <summary>
        ///     Required
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyKeyInfo keyInfo { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyTimelineDataPoint[] points { get; set; }
    }
}