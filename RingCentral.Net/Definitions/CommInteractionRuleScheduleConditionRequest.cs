namespace RingCentral
{
    public class CommInteractionRuleScheduleConditionRequest
    {
        /// <summary>
        ///     Interaction condition type resource
        ///     Required
        ///     Example: Schedule
        ///     Enum: Interaction, Schedule, State
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommInteractionRuleScheduleResource schedule { get; set; }
    }
}