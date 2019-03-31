namespace RingCentral
{
    public class EmergencyAddressInfo
    {
        /// <summary>
        /// Name of a customer
        /// </summary>
        public string customerName;

        /// <summary>
        /// Street address, line 1 - street address, P.O. box, company name, c/o
        /// </summary>
        public string street;

        /// <summary>
        /// Street address, line 2 - apartment, suite, unit, building, floor, etc.
        /// </summary>
        public string street2;

        /// <summary>
        /// City name
        /// </summary>
        public string city;

        /// <summary>
        /// Zip code
        /// </summary>
        public string zip;

        /// <summary>
        /// State/province name
        /// </summary>
        public string state;

        /// <summary>
        /// Internal identifier of a state
        /// </summary>
        public string stateId;

        /// <summary>
        /// ISO code of a state
        /// </summary>
        public string stateIsoCode;

        /// <summary>
        /// Full name of a state
        /// </summary>
        public string stateName;

        /// <summary>
        /// Internal identifier of a country
        /// </summary>
        public string countryId;

        /// <summary>
        /// ISO code of a country
        /// </summary>
        public string countryIsoCode;

        /// <summary>
        /// Country name
        /// </summary>
        public string country;

        /// <summary>
        /// Full name of a country
        /// </summary>
        public string countryName;

        /// <summary>
        /// Resulting status of emergency address synchronization. Returned for 'Get Device Info' request if `syncEmergencyAddress` parameter is set to 'True'
        /// Enum: Verified, Updated, Deleted, NotRequired, Unsupported, Failed
        /// </summary>
        public string syncStatus;
    }
}