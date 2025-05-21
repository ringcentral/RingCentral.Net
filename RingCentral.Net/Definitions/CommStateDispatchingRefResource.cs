namespace RingCentral
{
    public class CommStateDispatchingRefResource
    {
        /// <summary>
        ///     Id/Type of a state the rule is based on
        ///     Required
        ///     Enum: after-hours, work-hours, dnd, forward-all-calls, agent
        /// </summary>
        public string ruleId { get; set; }

        /// <summary>
        /// </summary>
        public CommStateDispatchingResource dispatching { get; set; }
    }
}