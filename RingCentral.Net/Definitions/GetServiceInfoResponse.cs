namespace RingCentral
{
    public class GetServiceInfoResponse
    {
        /// <summary>
        /// Canonical URI of the account Service Info resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Account Service Plan name
        /// </summary>
        public string servicePlanName;

        /// <summary>
        /// </summary>
        public BrandInfo brand;

        /// <summary>
        /// </summary>
        public ContractedCountryInfo contractedCountry;

        /// <summary>
        /// </summary>
        public ServicePlanInfo servicePlan;

        /// <summary>
        /// </summary>
        public TargetServicePlanInfo targetServicePlan;

        /// <summary>
        /// </summary>
        public BillingPlanInfo billingPlan;

        /// <summary>
        /// Service features information, see Service Feature List
        /// </summary>
        public ServiceFeatureInfo[] serviceFeatures;

        /// <summary>
        /// </summary>
        public AccountLimits limits;

        /// <summary>
        /// </summary>
        public PackageInfo package;
    }
}