namespace RingCentral
{
    public class CommInteractionRuleInteractionConditionResource
    {
        /// <summary>
        ///     Interaction condition type resource
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