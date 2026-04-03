namespace RingCentral
{
    /// <summary>
    /// Address for emergency cases. The same emergency address is assigned to all numbers of a single device
    /// </summary>
    public class DeviceEmergencyServiceAddressResource
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
        ///     City name
        /// </summary>
        public string city { get; set; }

        /// <summary>
        ///     Customer name
        /// </summary>
        public string customerName { get; set; }

        /// <summary>
        ///     Email of a primary contact person (receiver). Should be specified
        ///     for countries except the US, Canada, the UK and Australia
        ///     Format: email
        /// </summary>
        public string customerEmail { get; set; }

        /// <summary>
        ///     Email of an additional contact person. Should be specified
        ///     for countries except the US, Canada, the UK and Australia
        ///     Format: email
        /// </summary>
        public string additionalCustomerEmail { get; set; }

        /// <summary>
        ///     Name of an additional contact person. Should be specified for
        ///     countries except the US, Canada, the UK and Australia
        /// </summary>
        public string additionalCustomerName { get; set; }

        /// <summary>
        ///     Phone number of a primary contact person (receiver). Should
        ///     be specified for countries except the US, Canada, the UK and Australia
        /// </summary>
        public string customerPhone { get; set; }

        /// <summary>
        ///     Phone number of an additional contact person. Should be specified
        ///     for countries except the US, Canada, the UK & Australia
        /// </summary>
        public string additionalCustomerPhone { get; set; }

        /// <summary>
        ///     State/province name. Mandatory for the USA, the UK and Canada
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
        ///     First line address
        /// </summary>
        public string street { get; set; }

        /// <summary>
        ///     Second line address (apartment, suite, unit, building, floor,
        ///     etc.)
        /// </summary>
        public string street2 { get; set; }

        /// <summary>
        ///     Street type
        /// </summary>
        public string streetType { get; set; }

        /// <summary>
        ///     (Optional) Building name
        /// </summary>
        public string buildingName { get; set; }

        /// <summary>
        ///     Building/street number
        /// </summary>
        public string buildingNumber { get; set; }

        /// <summary>
        ///     Specifies if the emergency address is out of country
        /// </summary>
        public bool? outOfCountry { get; set; }

        /// <summary>
        ///     Postal (Zip) code
        /// </summary>
        public string zip { get; set; }

        /// <summary>
        ///     Status of a digital line provisioning
        ///     Enum: Provisioning, Valid, Invalid
        /// </summary>
        public string lineProvisioningStatus { get; set; }

        /// <summary>
        ///     Resulting status of emergency address synchronization. Returned
        ///     if `syncEmergencyAddress` parameter is set to `true`
        ///     Enum: Verified, Updated, Deleted, NotRequired, Unsupported, Failed
        /// </summary>
        public string syncStatus { get; set; }

        /// <summary>
        ///     Internal identifier of a tax
        /// </summary>
        public string taxId { get; set; }
    }
}