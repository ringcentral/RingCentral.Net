namespace RingCentral
{
    // Emergency address assigned to the switch. Only one of a pair `emergencyAddress` or `emergencyLocationId` should be specified, otherwise the error is returned || Emergency address assigned to the wireless point. Only one of a pair `emergencyAddress` or `emergencyLocationId` should be specified, otherwise the error is returned || Emergency address information. Only one of a pair `emergencyAddress` or `emergencyLocationId` should be specified, otherwise the error is returned
    public class LocationUpdatesEmergencyAddressInfo
    {
        /// <summary>
        /// Country name
        /// </summary>
        public string country;

        /// <summary>
        /// Internal identifier of a country
        /// </summary>
        public string countryId;

        /// <summary>
        /// ISO code of a country
        /// </summary>
        public string countryIsoCode;

        /// <summary>
        /// Full name of a country
        /// </summary>
        public string countryName;

        /// <summary>
        /// Customer name
        /// </summary>
        public string customerName;

        /// <summary>
        /// State/Province name. Mandatory for the USA, the UK and Canada
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
        /// City name
        /// </summary>
        public string city;

        /// <summary>
        /// First line address
        /// </summary>
        public string street;

        /// <summary>
        /// Second line address (apartment, suite, unit, building, floor, etc.)
        /// </summary>
        public string street2;

        /// <summary>
        /// Postal (Zip) code
        /// </summary>
        public string zip;
    }
}