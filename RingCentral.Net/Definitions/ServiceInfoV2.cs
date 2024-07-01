namespace RingCentral
{
    /// <summary>
    ///     Service Plan information (billing package, brand, etc.)
    /// </summary>
    public class ServiceInfoV2
    {
        /// <summary>
        ///     Required
        /// </summary>
        public ServiceInfoPackage package { get; set; }

        /// <summary>
        /// </summary>
        public ServiceInfoBrand brand { get; set; }

        /// <summary>
        /// </summary>
        public ServiceInfoCountryShortModel contractedCountry { get; set; }

        /// <summary>
        /// </summary>
        public ServiceInfoUBrand uBrand { get; set; }

        /// <summary>
        /// </summary>
        public ServiceInfoPlan servicePlan { get; set; }
    }
}