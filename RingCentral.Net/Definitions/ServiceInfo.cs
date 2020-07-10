namespace RingCentral
{
    public class ServiceInfo
    {
        /// <summary>
        /// Canonical URI of a service info resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Information on account billing plan
        /// </summary>
        public BillingPlanInfo billingPlan;

        /// <summary>
        /// Information on account brand
        /// </summary>
        public BrandInfo brand;

        /// <summary>
        /// Information on account service plan
        /// </summary>
        public ServicePlanInfo servicePlan;

        /// <summary>
        /// Information on account target service plan
        /// </summary>
        public TargetServicePlanInfo targetServicePlan;

        /// <summary>
        /// Information on the contracted country of account
        /// </summary>
        public ContractedCountryInfo contractedCountry;
    }
}