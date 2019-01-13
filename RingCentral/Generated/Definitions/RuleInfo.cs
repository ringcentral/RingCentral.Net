using Newtonsoft.Json;

namespace RingCentral
{
    public class RuleInfo : Serializable
    {
        // Forwarding number (or group) ordinal
        public int? index;
        // Number of rings for a forwarding number (or group)
        public int? ringCount;
        // Forwarding number status. Returned only if `showInactiveNumbers` is set to `true`
        public bool? enabled;
        // Forwarding number (or group) data
        public ForwardingNumberInfoRules[] forwardingNumbers;
    }
}