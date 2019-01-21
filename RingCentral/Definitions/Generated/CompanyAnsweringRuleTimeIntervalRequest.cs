using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CompanyAnsweringRuleTimeIntervalRequest : Serializable
    {
        // Time in format hh:mm
        public string from;
        // Time in format hh:mm
        public string to;
    }
}