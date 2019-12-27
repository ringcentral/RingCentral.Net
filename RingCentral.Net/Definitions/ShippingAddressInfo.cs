namespace RingCentral
{
    public class ShippingAddressInfo
    {
        /// <summary>
        /// Name of a primary contact person (receiver)
        /// </summary>
        public string customerName;

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
        /// Zip code
        /// </summary>
        public string zip;

        /// <summary>
        /// National taxpayer identification number. Should be specified for Brazil (CNPJ/CPF number) and Argentina (CUIT number).
        /// </summary>
        public string taxId;
    }
}