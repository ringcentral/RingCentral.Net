namespace RingCentral
{
    public class CommRangeTriggerResource
    {
        /// <summary>
        ///     Trigger type
        ///     Required
        ///     Example: Range
        ///     Enum: Daily, Weekly, Range
        /// </summary>
        public string triggerType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommRangeResource[] ranges { get; set; }
    }
}