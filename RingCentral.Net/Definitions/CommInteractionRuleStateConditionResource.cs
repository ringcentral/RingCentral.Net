namespace RingCentral
{
    public class CommInteractionRuleStateConditionResource
    {
        /// <summary>
        ///     Interaction condition type resource
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