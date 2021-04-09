namespace RingCentral
{
    // Emergency address information (or information assigned to the switch or wireless point - in case of using them). Only one of a pair `emergencyAddress` or `emergencyLocationId` should be specified, otherwise the error is returned
    public class LocationUpdatesEmergencyAddressInfo
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
        ///     ISO code of a country
        /// </summary>
        public string countryIsoCode { get; set; }

        /// <summary>
        ///     Full name of a country
        /// </summary>
        public string countryName { get; set; }

        /// <summary>
        ///     Customer name
        /// </summary>
        public string customerName { get; set; }

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
        ///     First line address
        /// </summary>
        public string street { get; set; }

        /// <summary>
        ///     Second line address (apartment, suite, unit, building, floor, etc.)
        /// </summary>
        public string street2 { get; set; }

        /// <summary>
        ///     Postal (Zip) code
        /// </summary>
        public string zip { get; set; }
    }
}