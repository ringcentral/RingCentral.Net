using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CompanyAnsweringRuleCallersInfoRequest : Serializable
    {
        // Phone number of a caller
        public string callerId;
        // Displayed name for a caller ID
        public string name;
    }
}