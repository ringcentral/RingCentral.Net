namespace RingCentral
  {
    /// <summary>
/// Query parameters for operation parsePhoneNumber
/// </summary>
      public class ParsePhoneNumberParameters
      {
          /// <summary>
        ///     Two-letter country code in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format
        ///     Example: US
        /// </summary>
        public string homeCountry { get; set; }

        /// <summary>
        ///     The default value is `false`. If `true`, the numbers that are
            ///     closer to the home country are given higher priority
        /// </summary>
        public bool? nationalAsPriority { get; set; }
      }
  }