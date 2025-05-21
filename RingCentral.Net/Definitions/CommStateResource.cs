namespace RingCentral
{
    public class CommStateResource
    {
        /// <summary>
        ///     Id/Type of a state the rule is based on
        ///     Required
        ///     Enum: after-hours, work-hours, dnd, forward-all-calls, agent
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Specifies if a state is enabled or not. *Work Hours* and *After Hours* states cannot be disabled
        ///     Required
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Predefined name of a state-based rule (similar to the name of a state)
        ///     Required
        ///     Enum: After Hours, Work Hours, Do not disturb, Forward all calls, Agent
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public object[] conditions { get; set; }
    }
}