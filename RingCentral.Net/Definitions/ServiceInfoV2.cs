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
    }
}