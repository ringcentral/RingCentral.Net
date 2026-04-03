namespace RingCentral
{
    public class CommTriggerRequest
    {
        /// <summary>
        ///     Trigger type
        ///     Required
        ///     Enum: Daily, Weekly, Range
        /// </summary>
        public string triggerType { get; set; }
    }
}