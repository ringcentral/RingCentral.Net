namespace RingCentral
{
    public class CommInteractionRuleInteractionConditionRequest
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: Interaction
        ///     Enum: Interaction, Schedule, State
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommFromResource[] from { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public string[] to { get; set; }
    }
}