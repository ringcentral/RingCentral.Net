namespace RingCentral
{
    /// <summary>
    ///     Account service information, including brand, sub-brand, service plan and
    ///     billing plan
    /// </summary>
    public class ServiceInfo
    {
        /// <summary>
        ///     Canonical URI of a service info resource
        ///     Format: uri
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
        public CountryInfoShortModel contractedCountry { get; set; }

        /// <summary>
        /// </summary>
        public UBrandInfo uBrand { get; set; }
    }
}