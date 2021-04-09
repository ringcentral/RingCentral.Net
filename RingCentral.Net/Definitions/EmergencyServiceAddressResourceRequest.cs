namespace RingCentral
{
    // Address for emergency cases. The same emergency address is assigned to all numbers of a single device. If the emergency address is also specified in `emergency` resource, then this value is ignored
    public class EmergencyServiceAddressResourceRequest
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
        ///     Country name
        /// </summary>
        public string country { get; set; }

        /// <summary>
        ///     Internal identifier of a country
        /// </summary>
        public string countryId { get; set; }
    }
}