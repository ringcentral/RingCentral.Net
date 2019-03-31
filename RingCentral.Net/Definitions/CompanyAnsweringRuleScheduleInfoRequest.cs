namespace RingCentral
{
    public class CompanyAnsweringRuleScheduleInfoRequest
    {
        /* Weekly schedule. If specified, ranges cannot be specified */
        public CompanyAnsweringRuleWeeklyScheduleInfoRequest weeklyRanges;

        /* Specific data ranges. If specified, weeklyRanges cannot be specified */
        public RangesInfo[] ranges;

        /* Reference to Business Hours or After Hours schedule */
        // Enum: BusinessHours, AfterHours
        public string @ref;
    }
}