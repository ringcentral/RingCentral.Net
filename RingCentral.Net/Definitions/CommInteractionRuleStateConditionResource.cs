namespace RingCentral
{
    public class CommInteractionRuleStateConditionResource
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: State
        ///     Enum: Interaction, Schedule, State
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CommStateResource state { get; set; }
    }
}