namespace RingCentral
{
    public class RuleInfo
    {
        /* Forwarding number (or group) ordinal */
        public long? index;

        /* Number of rings for a forwarding number (or group) */
        public long? ringCount;

        /* Forwarding number status. Returned only if `showInactiveNumbers` is set to `true` */
        public bool? enabled;

        /* Forwarding number (or group) data */
        public ForwardingNumberInfoRules[] forwardingNumbers;
    }
}