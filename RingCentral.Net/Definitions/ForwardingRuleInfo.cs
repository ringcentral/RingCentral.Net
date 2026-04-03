namespace RingCentral
{
    public class ForwardingRuleInfo
    {
        /// <summary>
        ///     Forwarding number (or group) ordinal
        ///     Format: int32
        /// </summary>
        public long? index { get; set; }

        /// <summary>
        ///     Number of rings for a forwarding number (or group)
        ///     Format: int32
        /// </summary>
        public long? ringCount { get; set; }

        /// <summary>
        ///     Forwarding number status. Returned only if `showInactiveNumbers` is set to `true`
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Forwarding number (or group) data
        /// </summary>
        public CreateAnsweringRuleForwardingNumberInfo[] forwardingNumbers { get; set; }
    }
}