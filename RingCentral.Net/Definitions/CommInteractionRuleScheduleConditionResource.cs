namespace RingCentral
{
    public class CommInteractionRuleScheduleConditionResource
    {
        /// <summary>
        ///     Ring target type
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