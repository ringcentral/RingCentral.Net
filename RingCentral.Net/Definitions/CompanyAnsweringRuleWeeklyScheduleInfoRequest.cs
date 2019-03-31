namespace RingCentral
{
    public class CompanyAnsweringRuleWeeklyScheduleInfoRequest
    {
        /// <summary>
        /// Time interval for a particular day
        /// </summary>
        public CompanyAnsweringRuleTimeIntervalRequest[] monday;

        /// <summary>
        /// Time interval for a particular day
        /// </summary>
        public CompanyAnsweringRuleTimeIntervalRequest[] tuesday;

        /// <summary>
        /// Time interval for a particular day
        /// </summary>
        public CompanyAnsweringRuleTimeIntervalRequest[] wednesday;

        /// <summary>
        /// Time interval for a particular day
        /// </summary>
        public CompanyAnsweringRuleTimeIntervalRequest[] thursday;

        /// <summary>
        /// Time interval for a particular day
        /// </summary>
        public CompanyAnsweringRuleTimeIntervalRequest[] friday;

        /// <summary>
        /// Time interval for a particular day
        /// </summary>
        public CompanyAnsweringRuleTimeIntervalRequest[] saturday;

        /// <summary>
        /// Time interval for a particular day
        /// </summary>
        public CompanyAnsweringRuleTimeIntervalRequest[] sunday;
    }
}