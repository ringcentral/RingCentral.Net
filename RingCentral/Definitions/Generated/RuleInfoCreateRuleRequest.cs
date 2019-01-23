namespace RingCentral
{
    public class RuleInfoCreateRuleRequest : Serializable
    {
        // Forwarding number (or group) ordinal. Not returned for inactive numbers
        public long? index;
        // Number of rings for a forwarding number (or group). For inactive numbers the default value ('4') is returned
        public long? ringCount;
        // Phone number status
        public bool? enabled;
        // Forwarding number (or group) data
        public ForwardingNumberInfoRulesCreateRuleRequest[] forwardingNumbers;
    }
}