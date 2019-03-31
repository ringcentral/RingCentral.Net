namespace RingCentral
{
    public class ForwardingNumberInfoRulesCreateRuleRequest
    {
        /// <summary>
        /// Internal identifier of a forwarding number
        /// </summary>
        public string id;

        /// <summary>
        /// Forwarding phone number type
        /// Enum: Home, Mobile, Work, PhoneLine, Outage, Other
        /// </summary>
        public string type;
    }
}