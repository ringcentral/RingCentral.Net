namespace RingCentral
{
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
        /// Home country information
        /// </summary>
        public CountryInfo homeCountry;
    }
}