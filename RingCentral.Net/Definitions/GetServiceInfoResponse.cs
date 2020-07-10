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
        /// Information on account brand
        /// </summary>
        public BrandInfo brand;

        /// <summary>
        /// Information on the contracted country of account
        /// </summary>
        public ContractedCountryInfo contractedCountry;

        /// <summary>
        /// Information on account service plan
        /// </summary>
        public ServicePlanInfo servicePlan;

        /// <summary>
        /// </summary>
        public TargetServicePlanInfo targetServicePlan;

        /// <summary>
        /// Information on account billing plan
        /// </summary>
        public BillingPlanInfo billingPlan;

        /// <summary>
        /// Service features information, see Service Feature List
        /// </summary>
        public ServiceFeatureInfo[] serviceFeatures;

        /// <summary>
        /// Limits which are effective for the account
        /// </summary>
        public AccountLimits limits;

        /// <summary>
        /// </summary>
        public PackageInfo package;
    }
}