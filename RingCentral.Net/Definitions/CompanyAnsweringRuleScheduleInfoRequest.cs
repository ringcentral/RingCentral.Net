namespace RingCentral
{
    public class CompanyAnsweringRuleScheduleInfoRequest
    {
        /// <summary>
        /// Weekly schedule. If specified, ranges cannot be specified
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