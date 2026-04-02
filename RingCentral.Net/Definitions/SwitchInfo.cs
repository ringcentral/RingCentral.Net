namespace RingCentral
  {
      public class SwitchInfo
      {
          /// <summary>
        ///     Link to the network switch resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a network switch
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Unique identifier of a network switch. The supported formats
            ///     are: XX:XX:XX:XX:XX:XX (symbols 0-9 and A-F) for MAC address and X.X.X.X
            ///     for IP address (symbols 0-255)
        ///     Required
        /// </summary>
        public string chassisId { get; set; }

        /// <summary>
        ///     Switch entity extension for better diversity. 
            ///     Should be used together with chassisId
        /// </summary>
        public string port { get; set; }

        /// <summary>
        ///     Name of a network switch
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public SwitchSiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyAddressInfo emergencyAddress { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyLocationInfo emergencyLocation { get; set; }

        /// <summary>
        ///     Emergency response location (address) internal identifier. 
            ///     Only one of a pair `emergencyAddress` or `emergencyLocationId`
            ///     can be specified, otherwise the error is returned
        /// </summary>
        public string emergencyLocationId { get; set; }
      }
  }