namespace RingCentral
{
    // Account service information, including brand, service plan and billing plan
    public class ServiceInfo
    {
        /// <summary>
        /// Canonical URI of a service info resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public BillingPlanInfo billingPlan { get; set; }

        /// <summary>
        /// </summary>
        public BrandInfo brand { get; set; }

        /// <summary>
        /// </summary>
        public ServicePlanInfo servicePlan { get; set; }

        /// <summary>
        /// </summary>
        public TargetServicePlanInfo targetServicePlan { get; set; }

        /// <summary>
        /// </summary>
        public ContractedCountryInfo contractedCountry { get; set; }
    }
}