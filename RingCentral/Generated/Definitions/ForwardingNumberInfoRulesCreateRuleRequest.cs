using Newtonsoft.Json;

namespace RingCentral
{
    public class ForwardingNumberInfoRulesCreateRuleRequest : Serializable
    {
        // Internal identifier of a forwarding number
        public string id;
        // Forwarding phone number type
        public string type;
    }
}