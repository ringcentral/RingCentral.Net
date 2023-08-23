namespace RingCentral
{
    /// <summary>
    ///     Automatically determined emergency address. If `emergencyAddressState`
    ///     value is 'Assigned', then this address is assigned to the current device.
    ///     If `emergencyAddressState` value is 'Unconfirmed', then the specified address
    ///     must be confirmed by the user before being registered as emergency address
    ///     for the current device. In all other cases the value is null
    /// </summary>
    public class DeviceEmergencyAddressFr
    {
        /// <summary>
        ///     Name of a customer
        /// </summary>
        public string customerName { get; set; }

        /// <summary>
        ///     Street address, line 1 - street address, P.O. box, company name, c/o
        /// </summary>
        public string street { get; set; }

        /// <summary>
        ///     Street address, line 2 - apartment, suite, unit, building, floor, etc.
        /// </summary>
        public string street2 { get; set; }

        /// <summary>
        ///     City name
        /// </summary>
        public string city { get; set; }

        /// <summary>
        ///     Zip code
        /// </summary>
        public string zip { get; set; }

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
        ///     ISO code of a country
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
        ///     (Optional) Building name
        /// </summary>
        public string buildingName { get; set; }

        /// <summary>
        ///     Building/street number
        /// </summary>
        public string buildingNumber { get; set; }

        /// <summary>
        ///     Resulting status of emergency address synchronization. Returned
        ///     for 'Get Device Info' request if `syncEmergencyAddress` parameter is set
        ///     to 'True'
        ///     Enum: Verified, Updated, Deleted, NotRequired, Unsupported, Failed
        /// </summary>
        public string syncStatus { get; set; }
    }
}