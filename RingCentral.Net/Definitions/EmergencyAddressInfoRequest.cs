namespace RingCentral
{
    public class EmergencyAddressInfoRequest
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
        /// Country name
        /// </summary>
        public string country;
    }
}