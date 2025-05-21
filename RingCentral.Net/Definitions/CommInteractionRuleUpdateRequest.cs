namespace RingCentral
{
    /// <summary>
    ///     Interaction rule update request
    /// </summary>
    public class CommInteractionRuleUpdateRequest
    {
        /// <summary>
        /// </summary>
        public object[] conditions { get; set; }

        /// <summary>
        /// </summary>
        public CommDispatchingRequest dispatching { get; set; }

        /// <summary>
        ///     Specifies if a rule is enabled or not. *Work Hours* and *After Hours* rules cannot be disabled
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Custom name of a rule
        /// </summary>
        public string displayName { get; set; }
    }
}