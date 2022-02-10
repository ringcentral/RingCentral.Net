namespace RingCentral
{
    /// <summary>
    ///     Information on account brand
    /// </summary>
    public class BrandInfo
    {
        /// <summary>
        ///     Internal identifier of a brand
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Brand name, for example  RingCentral UK ,  ClearFax
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public CountryInfo homeCountry { get; set; }
    }
}