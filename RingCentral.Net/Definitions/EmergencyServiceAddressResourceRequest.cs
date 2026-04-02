namespace RingCentral
  {
    /// <summary>
/// Address for emergency cases. The same emergency address is assigned to all
/// numbers of a single device. If the emergency address is also specified in
/// `emergency` resource, then this value is ignored
/// 
/// </summary>
      public class EmergencyServiceAddressResourceRequest
      {
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
        ///     Postal (Zip) code
        /// </summary>
        public string zip { get; set; }

        /// <summary>
        ///     Customer name
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