namespace RingCentral
{
    /// <summary>
    ///     State-based rule information
    /// </summary>
    public class CommStateBasedRuleResource
    {
        /// <summary>
        ///     Id/Type of a state the rule is based on
        ///     Required
        ///     Enum: after-hours, work-hours, dnd, forward-all-calls, agent
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Predefined name of a state-based rule (similar to the name of a state)
        ///     Required
        ///     Enum: After Hours, Work Hours, Do not disturb, Forward all calls, Agent
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommStateDispatchingResource dispatching { get; set; }

        /// <summary>
        /// </summary>
        public CommStateDispatchingRefResource dispatchingRef { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommStateResource state { get; set; }
    }
}