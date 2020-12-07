namespace RingCentral
{
    // Information on account brand
    public class BrandInfo
    {
        /// <summary>
        /// Internal identifier of a brand
        /// </summary>
        public string id;

        /// <summary>
        /// Brand name, for example  RingCentral UK ,  ClearFax
        /// </summary>
        public string name;

        /// <summary>
        /// </summary>
        public CountryInfo homeCountry;
    }
}