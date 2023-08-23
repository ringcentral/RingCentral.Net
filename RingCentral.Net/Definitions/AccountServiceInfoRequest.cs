namespace RingCentral
{
    /// <summary>
    ///     Account service information, including brand, service plan and billing plan
    /// </summary>
    public class AccountServiceInfoRequest
    {
        /// <summary>
        ///     Canonical URI of the account Service Info resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Account Service Plan name
        /// </summary>
        public string servicePlanName { get; set; }

        /// <summary>
        /// </summary>
        public BrandInfo brand { get; set; }

        /// <summary>
        /// </summary>
        public CountryInfoShortModel contractedCountry { get; set; }

        /// <summary>
        /// </summary>
        public ServicePlanInfo servicePlan { get; set; }

        /// <summary>
        /// </summary>
        public TargetServicePlanInfo targetServicePlan { get; set; }

        /// <summary>
        /// </summary>
        public BillingPlanInfo billingPlan { get; set; }

        /// <summary>
        ///     Service features information, see Service Feature List
        /// </summary>
        public ServiceFeatureInfo[] serviceFeatures { get; set; }

        /// <summary>
        /// </summary>
        public AccountLimits limits { get; set; }

        /// <summary>
        /// </summary>
        public PackageInfo package { get; set; }
    }
}