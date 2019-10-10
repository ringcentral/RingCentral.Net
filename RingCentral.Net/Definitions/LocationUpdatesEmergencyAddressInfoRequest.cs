namespace RingCentral
{
    public class LocationUpdatesEmergencyAddressInfoRequest
    {
        /// <summary>
        /// Country name
        /// </summary>
        public string country;

        /// <summary>
        /// State/Province name. Mandatory for the USA, the UK and Canada
        /// </summary>
        public string state;

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