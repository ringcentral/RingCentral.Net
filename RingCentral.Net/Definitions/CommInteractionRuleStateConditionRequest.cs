namespace RingCentral
{
    public class CommInteractionRuleStateConditionRequest
    {
        /// <summary>
        ///     Interaction condition type resource
        ///     Required
        ///     Example: State
        ///     Enum: Interaction, Schedule, State
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommReferenceStateResource state { get; set; }
    }
}