namespace RingCentral
{
    // Address for emergency cases. The same emergency address is assigned to all the numbers of one device || Address for emergency cases. The same emergency address is assigned to all numbers of a single device ||  Address for emergency cases. The same emergency address is assigned to all numbers of a single device
    public class EmergencyServiceAddressResource
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
        /// ISO code of a state
        /// </summary>
        public string stateIsoCode;

        /// <summary>
        /// Full name of a state
        /// </summary>
        public string stateName;

        /// <summary>
        /// Internal identifier of a country
        /// </summary>
        public string countryId;

        /// <summary>
        /// ISO code of a country
        /// </summary>
        public string countryIsoCode;

        /// <summary>
        /// Country name
        /// </summary>
        public string country;

        /// <summary>
        /// Full name of a country
        /// </summary>
        public string countryName;

        /// <summary>
        /// Specifies if emergency address is out of country
        /// </summary>
        public bool? outOfCountry;

        /// <summary>
        /// Resulting status of emergency address synchronization. Returned if `syncEmergencyAddress` parameter is set to 'True'
        /// Enum: Verified, Updated, Deleted, NotRequired, Unsupported, Failed
        /// </summary>
        public string syncStatus;

        /// <summary>
        /// Name of an additional contact person. Should be specified for countries except the US, Canada, the UK and Australia.
        /// </summary>
        public string additionalCustomerName;

        /// <summary>
        /// Email of a primary contact person (receiver). Should be specified for countries except the US, Canada, the UK and Australia.
        /// </summary>
        public string customerEmail;

        /// <summary>
        /// Email of an additional contact person. Should be specified for countries except the US, Canada, the UK and Australia.
        /// </summary>
        public string additionalCustomerEmail;

        /// <summary>
        /// Phone number of a primary contact person (receiver). Should be specified for countries except the US, Canada, the UK and Australia
        /// </summary>
        public string customerPhone;

        /// <summary>
        /// Phone number of an additional contact person. Should be specified for countries except the US, Canada, the UK & Australia.
        /// </summary>
        public string additionalCustomerPhone;

        /// <summary>
        /// Internal identifier of a tax
        /// </summary>
        public string taxId;
    }
}