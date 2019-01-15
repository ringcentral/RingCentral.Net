using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ServiceInfo : Serializable
    {
        // Canonical URI of a service info resource
        public string uri;
        // Information on account billing plan
        public BillingPlanInfo billingPlan;
        // Information on account brand
        public BrandInfo brand;
        // Information on account service plan
        public ServicePlanInfo servicePlan;
        // Information on account target service plan
        public TargetServicePlanInfo targetServicePlan;
    }
}