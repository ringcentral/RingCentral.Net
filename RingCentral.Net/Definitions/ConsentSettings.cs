namespace RingCentral
  {
    /// <summary>
/// Info about consent configuration for the TCR campaign.
/// </summary>
      public class ConsentSettings
      {
          /// <summary>
        ///     Opt-in necessity for outbound communications.
        /// </summary>
        public bool? optInRequired { get; set; }

        /// <summary>
        /// </summary>
        public ConsentSettingsCoverage coverage { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticConsentCollecting automaticConsentCollecting { get; set; }
      }
  }