namespace RingCentral
{
    // Address for emergency cases. The same emergency address is assigned to all numbers of a single device. If the emergency address is also specified in `emergency` resource, then this value is ignored
    public class EmergencyServiceAddressResourceRequest
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
        /// Country name
        /// </summary>
        public string country;

        /// <summary>
        /// Internal identifier of a country
        /// </summary>
        public string countryId;
    }
}