namespace RingCentral
  {
      public class CallNotesInfo
      {
          /// <summary>
        /// </summary>
        public bool? notifyByEmail { get; set; }

        /// <summary>
        /// </summary>
        public bool? notifyBySms { get; set; }

        /// <summary>
        /// </summary>
        public string[] advancedEmailAddresses { get; set; }

        /// <summary>
        /// </summary>
        public string[] advancedSmsEmailAddresses { get; set; }
      }
  }