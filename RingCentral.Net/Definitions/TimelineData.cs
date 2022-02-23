namespace RingCentral
{
    public class TimelineData
    {
        /// <summary>
        ///     Required
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// </summary>
        public KeyInfo keyInfo { get; set; }

        /// <summary>
        /// </summary>
        public TimelineDataPoint[] points { get; set; }
    }
}