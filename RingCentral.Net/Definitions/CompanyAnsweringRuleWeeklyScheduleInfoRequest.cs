namespace RingCentral
{
    // Weekly schedule. If specified, ranges cannot be specified
    public class CompanyAnsweringRuleWeeklyScheduleInfoRequest
    {
        /// <summary>
        /// Time interval for a particular day
        /// </summary>
        public CompanyAnsweringRuleTimeIntervalRequest[] monday { get; set; }

        /// <summary>
        /// Time interval for a particular day
        /// </summary>
        public CompanyAnsweringRuleTimeIntervalRequest[] tuesday { get; set; }

        /// <summary>
        /// Time interval for a particular day
        /// </summary>
        public CompanyAnsweringRuleTimeIntervalRequest[] wednesday { get; set; }

        /// <summary>
        /// Time interval for a particular day
        /// </summary>
        public CompanyAnsweringRuleTimeIntervalRequest[] thursday { get; set; }

        /// <summary>
        /// Time interval for a particular day
        /// </summary>
        public CompanyAnsweringRuleTimeIntervalRequest[] friday { get; set; }

        /// <summary>
        /// Time interval for a particular day
        /// </summary>
        public CompanyAnsweringRuleTimeIntervalRequest[] saturday { get; set; }

        /// <summary>
        /// Time interval for a particular day
        /// </summary>
        public CompanyAnsweringRuleTimeIntervalRequest[] sunday { get; set; }
    }
}