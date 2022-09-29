namespace RingCentral
{
    public class ForwardingRuleCreateRequest
    {
        /// <summary>
        ///     Forwarding number (or group) ordinal. Not returned for inactive numbers
        ///     Format: int32
        /// </summary>
        public long? index { get; set; }

        /// <summary>
        ///     Number of rings for a forwarding number (or group). For inactive
        ///     numbers the default value ('4') is returned
        ///     Format: int32
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