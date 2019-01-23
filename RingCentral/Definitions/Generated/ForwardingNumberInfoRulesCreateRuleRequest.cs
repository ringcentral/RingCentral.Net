namespace RingCentral
{
    public class ForwardingNumberInfoRulesCreateRuleRequest : Serializable
    {
        // Internal identifier of a forwarding number
        public string id;
        // Forwarding phone number type
        // Enum: Home, Mobile, Work, PhoneLine, Outage, Other
        public string type;
    }
}