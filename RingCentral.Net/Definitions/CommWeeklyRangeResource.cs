namespace RingCentral
{
    public class CommWeeklyRangeResource
    {
        /// <summary>
        ///     Start time in format hh:mm:ss
        ///     Required
        ///     Format: time
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     End time in format hh:mm:ss
        ///     Required
        ///     Format: time
        /// </summary>
        public string endTime { get; set; }
    }
}