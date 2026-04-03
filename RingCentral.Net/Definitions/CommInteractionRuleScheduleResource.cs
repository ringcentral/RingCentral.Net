namespace RingCentral
{
    public class CommInteractionRuleScheduleResource
    {
        /// <summary>
        ///     Start date-time
        /// </summary>
        public string startDateTime { get; set; }

        /// <summary>
        ///     End date-time
        /// </summary>
        public string endDateTime { get; set; }

        /// <summary>
        ///     Trigger information
        /// </summary>
        public CommInteractionRuleScheduleResourceTriggers[] triggers { get; set; }
    }
}