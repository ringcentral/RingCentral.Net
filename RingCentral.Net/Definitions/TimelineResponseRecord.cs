namespace RingCentral
{
    public class TimelineResponseRecord
    {
        /// <summary>
        ///     Grouping key
        ///     Required
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// </summary>
        public KeyInfo info { get; set; }

        /// <summary>
        ///     List of requested call data time-value points
        /// </summary>
        public TimelineResponsePoint[] points { get; set; }
    }
}