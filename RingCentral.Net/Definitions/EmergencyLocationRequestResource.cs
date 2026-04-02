namespace RingCentral
  {
      public class EmergencyLocationRequestResource
      {
          /// <summary>
        /// </summary>
        public EmergencyAddressResourceRequest address { get; set; }

        /// <summary>
        ///     Emergency response location name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public SiteBasicInfo site { get; set; }

        /// <summary>
        ///     Address format ID
        /// </summary>
        public string addressFormatId { get; set; }

        /// <summary>
        ///     Visibility of an emergency response location. If `Private`
            ///     is set, then a location is visible only for restricted number of users,
            ///     specified in `owners` array
        ///     Default: Public
        ///     Enum: Public
        /// </summary>
        public string visibility { get; set; }

        /// <summary>
        ///     Specifies emergency address validation during the ERL creation/update.
            ///     If set to 'true', then address validation for non-US addresses is skipped
        /// </summary>
        public bool? trusted { get; set; }
      }
  }