namespace RingCentral
{
    // Address for emergency cases. The same emergency address is assigned to all the numbers of one device
    public class DeviceEmergencyServiceAddressResource
    {
        /// <summary>
        /// </summary>
        public string street;

        /// <summary>
        /// </summary>
        public string street2;

        /// <summary>
        /// </summary>
        public string city;

        /// <summary>
        /// </summary>
        public string zip;

        /// <summary>
        /// </summary>
        public string customerName;

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
        /// Specifies if emergency address is out of country
        /// </summary>
        public bool? outOfCountry;
    }
}