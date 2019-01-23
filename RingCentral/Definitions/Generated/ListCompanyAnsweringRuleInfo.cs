using Newtonsoft.Json;

namespace RingCentral
{
    public class ListCompanyAnsweringRuleInfo : Serializable
    {
        // Internal identifier of an answering rule
        public string id;
        // Canonical URI of an answering rule
        public string uri;
        // Specifies if the rule is active or inactive. The default value is 'True'
        public bool? enabled;
        // Type of an answering rule, the default value is 'Custom' = ['BusinessHours', 'AfterHours', 'Custom']
        // Enum: BusinessHours, AfterHours, Custom
        public string type;
        // Name of an answering rule specified by user. Max number of symbols is 30. The default value is 'My Rule N' where 'N' is the first free number
        public string name;
    }
}