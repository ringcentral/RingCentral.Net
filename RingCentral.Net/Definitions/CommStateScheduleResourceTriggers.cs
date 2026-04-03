namespace RingCentral
{
    public class CommStateScheduleResourceTriggers
    {
        /// <summary>
        ///     Trigger type
        ///     Example: Range
        ///     Enum: Daily, Weekly, Range
        /// </summary>
        public string triggerType { get; set; }

        /// <summary>
        ///     Start time in format hh:mm:ss
        ///     Format: time
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     End time in format hh:mm:ss
        ///     Format: time
        /// </summary>
        public string endTime { get; set; }

        /// <summary>
        /// </summary>
        public CommWeeklyItemsResource ranges { get; set; }
    }
}