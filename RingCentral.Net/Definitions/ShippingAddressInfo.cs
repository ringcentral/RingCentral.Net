namespace RingCentral
{
    /// <summary>
    ///     Shipping address for the order. If it coincides with the Emergency
    ///     Service Address, then can be omitted. By default the same value as the
    ///     emergencyServiceAddress. Multiple addresses can be specified; in case
    ///     an order contains several devices, they can be delivered to different addresses
    /// </summary>
    public class ShippingAddressInfo
    {
        /// <summary>
        ///     Name of a primary contact person (receiver)
        /// </summary>
        public string customerName { get; set; }

        /// <summary>
        ///     Name of an additional contact person. Should be specified for
        ///     countries except the US, Canada, the UK and Australia.
        /// </summary>
        public string additionalCustomerName { get; set; }

        /// <summary>
        ///     Email of a primary contact person (receiver). Should be specified
        ///     for countries except the US, Canada, the UK and Australia.
        ///     Format: email
        /// </summary>
        public string customerEmail { get; set; }

        /// <summary>
        ///     Email of an additional contact person. Should be specified
        ///     for countries except the US, Canada, the UK and Australia.
        ///     Format: email
        /// </summary>
        public string additionalCustomerEmail { get; set; }

        /// <summary>
        ///     Phone number of a primary contact person (receiver). Should
        ///     be specified for countries except the US, Canada, the UK and Australia
        /// </summary>
        public string customerPhone { get; set; }

        /// <summary>
        ///     Phone number of an additional contact person. Should be specified
        ///     for countries except the US, Canada, the UK & Australia.
        /// </summary>
        public string additionalCustomerPhone { get; set; }

        /// <summary>
        ///     Street address, line 1 - street address, P.O. box, company
        ///     name, c/o
        /// </summary>
        public string street { get; set; }

        /// <summary>
        ///     Street address, line 2 - apartment, suite, unit, building,
        ///     floor, etc.
        /// </summary>
        public string street2 { get; set; }

        /// <summary>
        ///     City name
        /// </summary>
        public string city { get; set; }

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
        ///     Zip code
        /// </summary>
        public string zip { get; set; }

        /// <summary>
        ///     National taxpayer identification number. Should be specified
        ///     for Brazil (CNPJ/CPF number) and Argentina (CUIT number).
        /// </summary>
        public string taxId { get; set; }
    }
}