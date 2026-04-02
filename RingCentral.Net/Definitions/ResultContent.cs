namespace RingCentral
  {
    /// <summary>
/// Flags controlling parsing result content.
/// </summary>
      public class ResultContent
      {
          /// <summary>
        ///     Indicates that `results.dialingDetails` section should be returned for particular result items in the response.
        ///     Default: true
        /// </summary>
        public bool? includeDialingDetails { get; set; }

        /// <summary>
        ///     Indicates that `results.numberDetails` section should be returned for particular result items in the response.
        ///     Example: true
        ///     Default: true
        /// </summary>
        public bool? includeNumberDetails { get; set; }

        /// <summary>
        ///     Indicates that `results.formats` section should be returned for particular result items in the response.
        ///     Example: true
        ///     Default: true
        /// </summary>
        public bool? includeFormats { get; set; }
      }
  }