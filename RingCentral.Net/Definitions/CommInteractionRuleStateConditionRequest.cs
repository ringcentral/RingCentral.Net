namespace RingCentral
{
    public class CommInteractionRuleStateConditionRequest
    {
        /// <summary>
        ///     Ring target type
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