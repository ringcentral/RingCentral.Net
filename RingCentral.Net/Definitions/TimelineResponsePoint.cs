namespace RingCentral
{
    public class TimelineResponsePoint
    {
        /// <summary>
        ///     Time point in RFC 3339 format
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string time { get; set; }

        /// <summary>
        /// </summary>
        public CallsTimers timers { get; set; }

        /// <summary>
        /// </summary>
        public CallsCounters counters { get; set; }
    }
}