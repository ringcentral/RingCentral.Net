namespace RingCentral
{
    /// <summary>
    ///     Address for emergency cases. The same emergency address is assigned to all the numbers of one device
    /// </summary>
    public class DeviceEmergencyServiceAddressResourceAu
    {
        /// <summary>
        /// </summary>
        public string street { get; set; }

        /// <summary>
        /// </summary>
        public string street2 { get; set; }

        /// <summary>
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// </summary>
        public string zip { get; set; }

        /// <summary>
        /// </summary>
        public string customerName { get; set; }

        /// <summary>
        ///     State/province name
        /// </summary>
        public string state { get; set; }

        /// <summary>
        ///     Internal identifier of a state
        /// </summary>
        public string stateId { get; set; }

        /// <summary>
        ///     ISO code of a state
        /// </summary>
        public string stateIsoCode { get; set; }

        /// <summary>
        ///     Full name of a state
        /// </summary>
        public string stateName { get; set; }

        /// <summary>
        ///     Internal identifier of a country
        /// </summary>
        public string countryId { get; set; }

        /// <summary>
        ///     Two-letter country code in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format
        ///     Example: US
        /// </summary>
        public string countryIsoCode { get; set; }

        /// <summary>
        ///     Country name
        /// </summary>
        public string country { get; set; }

        /// <summary>
        ///     Full name of a country
        /// </summary>
        public string countryName { get; set; }

        /// <summary>
        ///     Specifies if emergency address is out of country
        /// </summary>
        public bool? outOfCountry { get; set; }

        /// <summary>
        ///     (Optional) Building name
        /// </summary>
        public string buildingName { get; set; }

        /// <summary>
        ///     Street type
        /// </summary>
        public string streetType { get; set; }

        /// <summary>
        ///     Building/street number
        /// </summary>
        public string buildingNumber { get; set; }
    }
}