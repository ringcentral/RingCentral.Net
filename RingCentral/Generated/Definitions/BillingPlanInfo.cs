using Newtonsoft.Json;

namespace RingCentral
{
    public class BillingPlanInfo : Serializable
    {
        // Internal identifier of a billing plan
        public string id;
        // Billing plan name
        public string name;
        // Duration period
        public string durationUnit;
        // Number of duration units
        public string duration;
        // Billing plan type
        public string type;
    }
}