namespace RingCentral
  {
      public class ParsePhoneNumberResponseV2Results
      {
          /// <summary>
        /// </summary>
        public DialingDetails dialingDetails { get; set; }

        /// <summary>
        /// </summary>
        public NumberDetails numberDetails { get; set; }

        /// <summary>
        ///     Contains several items for the `results.category` response's attribute value `Ambiguous`,
            ///     where each item represents formatting for a specific category from the list of categories between which ambiguity happened,
            ///     e.g. `Extension` and `Regular`, or `Extension` and `ShortCode`.
            ///     
            ///     Absent if the request's parameter `resultContent.includeFormats` value is set to `false`.
        /// </summary>
        public object[] formats { get; set; }
      }
  }