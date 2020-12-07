namespace RingCentral
{
    // Home country information || Brief information on a phone number country || Home country setting. For extension bulk assignment is configured automatically based on contact info setting
    public class CountryResource
    {
        /// <summary>
        /// </summary>
        public string uri;

        /// <summary>
        /// </summary>
        public string id;

        /// <summary>
        /// </summary>
        public string name;

        /// <summary>
        /// </summary>
        public string isoCode;

        /// <summary>
        /// </summary>
        public string callingCode;

        /// <summary>
        /// </summary>
        public bool? emergencyCalling;

        /// <summary>
        /// </summary>
        public bool? numberSelling;

        /// <summary>
        /// </summary>
        public bool? loginAllowed;
    }
}