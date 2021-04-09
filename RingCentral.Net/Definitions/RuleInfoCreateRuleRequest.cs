namespace RingCentral
{
    public class RuleInfoCreateRuleRequest
    {
        /// <summary>
        ///     Forwarding number (or group) ordinal. Not returned for inactive numbers
        /// </summary>
        public long? index { get; set; }

        /// <summary>
        ///     Number of rings for a forwarding number (or group). For inactive numbers the default value ('4') is returned
        /// </summary>
        public long? ringCount { get; set; }

        /// <summary>
        ///     Phone number status
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Forwarding number (or group) data
        /// </summary>
        public ForwardingNumberInfoRulesCreateRuleRequest[] forwardingNumbers { get; set; }
    }
}