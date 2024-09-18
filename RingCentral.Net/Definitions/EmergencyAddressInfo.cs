namespace RingCentral
{
    public class EmergencyAddressInfo
    {
        /// <summary>
        ///     Country name
        /// </summary>
        public string country { get; set; }

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
        ///     Full name of a country
        /// </summary>
        public string countryName { get; set; }

        /// <summary>
        ///     State/Province name. Mandatory for the USA, the UK and Canada
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
        ///     City name
        /// </summary>
        public string city { get; set; }

        /// <summary>
        ///     The name of the street (The field is utilized as 'streetName' field for FR addresses)
        /// </summary>
        public string street { get; set; }

        /// <summary>
        ///     Second line address (apartment, suite, unit, building, floor,
        ///     etc.)
        /// </summary>
        public string street2 { get; set; }

        /// <summary>
        ///     Postal (Zip) code
        /// </summary>
        public string zip { get; set; }

        /// <summary>
        ///     Customer name
        /// </summary>
        public string customerName { get; set; }

        /// <summary>
        ///     Company name
        /// </summary>
        public string companyName { get; set; }

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

        /// <summary>
        ///     Resulting status of emergency address synchronization. Returned
        ///     for 'Get Device Info' request if `syncEmergencyAddress` parameter is set
        ///     to `true`
        ///     Enum: Verified, Updated, Deleted, NotRequired, Unsupported, Failed
        /// </summary>
        public string syncStatus { get; set; }
    }
}