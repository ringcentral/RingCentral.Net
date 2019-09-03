namespace RingCentral
{
    public class RuleInfo
    {
        /// <summary>
        /// Forwarding number (or group) ordinal
        /// </summary>
        public long? index;

        /// <summary>
        /// Number of rings for a forwarding number (or group)
        /// </summary>
        public long? ringCount;

        /// <summary>
        /// Forwarding number status. Returned only if `showInactiveNumbers` is set to `true`
        /// </summary>
        public bool? enabled;

        /// <summary>
        /// Forwarding number (or group) data
        /// </summary>
        public CreateAnsweringRuleForwardingNumberInfo[] forwardingNumbers;
    }
}