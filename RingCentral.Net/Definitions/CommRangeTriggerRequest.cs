namespace RingCentral
{
    public class CommRangeTriggerRequest
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
        public CommRangeRequest[] ranges { get; set; }
    }
}