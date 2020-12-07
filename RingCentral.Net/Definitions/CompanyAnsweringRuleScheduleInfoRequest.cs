namespace RingCentral
{
    // Schedule when an answering rule should be applied
    public class CompanyAnsweringRuleScheduleInfoRequest
    {
        /// <summary>
        /// </summary>
        public CompanyAnsweringRuleWeeklyScheduleInfoRequest weeklyRanges;

        /// <summary>
        /// Specific data ranges. If specified, weeklyRanges cannot be specified
        /// </summary>
        public RangesInfo[] ranges;

        /// <summary>
        /// Reference to Business Hours or After Hours schedule
        /// Enum: BusinessHours, AfterHours
        /// </summary>
        public string @ref;
    }
}