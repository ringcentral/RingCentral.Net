namespace RingCentral
{
    // Account service information, including brand, service plan and billing plan
    public class ServiceInfo
    {
        /// <summary>
        /// Canonical URI of a service info resource
        /// </summary>
        public string uri;

        /// <summary>
        /// </summary>
        public BillingPlanInfo billingPlan;

        /// <summary>
        /// </summary>
        public BrandInfo brand;

        /// <summary>
        /// </summary>
        public ServicePlanInfo servicePlan;

        /// <summary>
        /// </summary>
        public TargetServicePlanInfo targetServicePlan;

        /// <summary>
        /// </summary>
        public ContractedCountryInfo contractedCountry;
    }
}