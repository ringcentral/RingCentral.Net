namespace RingCentral
{
    public class CommWeeklyTriggerRequest
    {
        /// <summary>
        ///     Trigger type
        ///     Required
        ///     Example: Weekly
        ///     Enum: Daily, Weekly, Range
        /// </summary>
        public string triggerType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommWeeklyItemsResource ranges { get; set; }
    }
}