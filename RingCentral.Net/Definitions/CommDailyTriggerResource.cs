namespace RingCentral
{
    public class CommDailyTriggerResource
    {
        /// <summary>
        ///     Trigger type
        ///     Required
        ///     Example: Daily
        ///     Enum: Daily, Weekly, Range
        /// </summary>
        public string triggerType { get; set; }

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