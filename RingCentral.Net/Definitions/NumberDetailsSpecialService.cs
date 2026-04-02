namespace RingCentral
  {
      public class NumberDetailsSpecialService
      {
          /// <summary>
        ///     The type of special service.
        ///     Example: NonEmergencyMedical
        ///     Enum: Emergency, DirectoryAssistance, UpdateEmergencyAddress, CustomerSupport, NonEmergencyPolice, NonEmergencyMedical, TelecommunicationRelay, Unsupported, Supplementary, Unknown
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Example: 116xxx
        /// </summary>
        public string pattern { get; set; }
      }
  }