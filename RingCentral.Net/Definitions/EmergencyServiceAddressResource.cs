namespace RingCentral
{
    // Address for emergency cases. The same emergency address is assigned to all the numbers of one device
    public class EmergencyServiceAddressResource
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
        ///     Specifies if emergency address is out of country
        /// </summary>
        public bool? outOfCountry { get; set; }

        /// <summary>
        ///     Resulting status of emergency address synchronization. Returned if `syncEmergencyAddress` parameter is set to 'True'
        ///     Enum: Verified, Updated, Deleted, NotRequired, Unsupported, Failed
        /// </summary>
        public string syncStatus { get; set; }

        /// <summary>
        ///     Name of an additional contact person. Should be specified for countries except the US, Canada, the UK and Australia.
        /// </summary>
        public string additionalCustomerName { get; set; }

        /// <summary>
        ///     Email of a primary contact person (receiver). Should be specified for countries except the US, Canada, the UK and Australia.
        /// </summary>
        public string customerEmail { get; set; }

        /// <summary>
        ///     Email of an additional contact person. Should be specified for countries except the US, Canada, the UK and Australia.
        /// </summary>
        public string additionalCustomerEmail { get; set; }

        /// <summary>
        ///     Phone number of a primary contact person (receiver). Should be specified for countries except the US, Canada, the UK and Australia
        /// </summary>
        public string customerPhone { get; set; }

        /// <summary>
        ///     Phone number of an additional contact person. Should be specified for countries except the US, Canada, the UK & Australia.
        /// </summary>
        public string additionalCustomerPhone { get; set; }

        /// <summary>
        ///     Status of digital line provisioning
        ///     Enum: Provisioning, Valid, Invalid
        /// </summary>
        public string lineProvisioningStatus { get; set; }

        /// <summary>
        ///     Internal identifier of a tax
        /// </summary>
        public string taxId { get; set; }
    }
}